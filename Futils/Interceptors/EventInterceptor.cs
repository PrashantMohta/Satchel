namespace Satchel.Futils
{
    /// <summary>
    /// Intercept an event and Invoke an Action
    /// </summary>
    public class EventInterceptor
    {
        public string fromState;
        public string eventName;
        public Func<bool> shouldIntercept = () => true;
        public Action onIntercept;

    }
}