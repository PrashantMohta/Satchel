using System.Runtime.CompilerServices;

namespace Satchel.Reflected
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="InstanceClass"></typeparam>
    public class InstanceClassWrapper<InstanceClass>
    {
        /// <summary>
        /// the original instance
        /// </summary>
        public InstanceClass orig;

        public InstanceClassWrapper(InstanceClass _orig)
        {
            orig = _orig;
        }

        protected TField GetField<TField>([CallerMemberName] string name = default)
        {
            return ReflectionHelper.GetField<InstanceClass, TField>(orig, name);
        }
        protected void SetField<TField>(TField val, [CallerMemberName] string name = default)
        {
            ReflectionHelper.SetField(orig, name, val);
        }
        protected TProperty GetProperty<TProperty>([CallerMemberName] string name = default)
        {
            return ReflectionHelper.GetProperty<InstanceClass, TProperty>(orig, name);
        }
        protected void SetProperty<TProperty>(TProperty val, [CallerMemberName] string name = default)
        {
            ReflectionHelper.SetProperty(orig, name, val);
        }
        protected void CallMethod(object[] param,[CallerMemberName] string name = default)
        {
            ReflectionHelper.CallMethod(orig, name, param);
        }
        protected TReturn CallMethod<TReturn>(object[] param, [CallerMemberName] string name = default)
        {
            return ReflectionHelper.CallMethod<InstanceClass, TReturn>(orig, name, param);
        }
        
        protected void CallMethod([CallerMemberName] string name = default)
        {
            ReflectionHelper.CallMethod(orig, name);
        }
        protected TReturn CallMethod<TReturn>([CallerMemberName] string name = default)
        {
            return ReflectionHelper.CallMethod<InstanceClass, TReturn>(orig, name);
        }
    }
}