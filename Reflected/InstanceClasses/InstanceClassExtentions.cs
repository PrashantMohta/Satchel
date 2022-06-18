namespace Satchel.Reflected
{
    public static class InstanceClassExtentions
    {
        /// <summary>
        /// Creates a reflected object that makes all the fields/methods public in health manager
        /// </summary>
        /// <param name="hm">the instance of HealthManager</param>
        /// <returns>The HealthManagerR object which makes all fields/methods public</returns>
        public static HealthManagerR Reflect(this HealthManager hm)
        {
            return new HealthManagerR(hm);
        }
    }
}