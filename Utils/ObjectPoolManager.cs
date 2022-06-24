namespace Satchel
{
    /// <summary>
    /// Allows Pooling Objects of type T
    /// </summary>
    /// <typeparam name="T">The type of objects to pool</typeparam>
    public class ObjectPoolManager<T>{
        public int poolSize = 0;
        public List<T> pool = new();
        public List<bool> inUse = new();
        protected Func<T> Generator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poolSize">The Initial size of the pool</param>
        /// <param name="Generator">Generator func that generates a new instance</param>
        public ObjectPoolManager(int poolSize,Func<T> Generator) {
            this.poolSize = poolSize;
            this.Generator = Generator;
            Populate();
        }

        public void Populate(){
            if(pool.Count < poolSize){
                for(var i = pool.Count; i < poolSize; i++){
                    pool.Add(Generator());
                    inUse.Add(false);
                }
            }
        }
        /// <summary>
        /// Pick one object from pool, instantiates a new one if unavailable
        /// </summary>
        /// <returns>Object of type T</returns>
        public T PickFromPool(){
            var index = inUse.FindIndex(i => i == false);
            if(index == -1){
                poolSize += 1;
                Populate();
                return PickFromPool();
            } else {
                inUse[index] = true;
                return pool[index];
            }
        }
        /// <summary>
        /// Recycle the object to the pool, throws if object was not part of the pool
        /// </summary>
        /// <param name="obj">Object to recycle</param>
        public void RecycleToPool(T obj){
            var index = pool.FindIndex(i => i.GetHashCode() == obj.GetHashCode());
            if(index == -1){
                throw new ArgumentOutOfRangeException("Passed object was not a pooled object");
            } else {
                inUse[index] = false;
            }
        }

    }
}