namespace Satchel.Futils
{
    /// <summary>
    /// Intercepts an FSMTransition and invokes onIntercept
    /// </summary>
    public class TransitionInterceptor
    {
        public string fromState;
        public string eventName;
        public string toStateDefault;
        public string toStateCustom;
        public Func<bool> shouldIntercept = () => true;
        public Action<string, string> onIntercept;
        public static string defaultEvent = "Intercept-DEFAULT";
        public static string customEvent = "Intercept-CUSTOM";
        public string GetNextEvent(string interceptedState, string interceptedEvent)
        {
            if (shouldIntercept != null && shouldIntercept())
            {
                if (onIntercept != null)
                {
                    onIntercept(interceptedState, interceptedEvent);
                }
                return TransitionInterceptor.customEvent;
            }
            return TransitionInterceptor.defaultEvent;
        }
        public string GetNextEventOrDefault(string interceptedState, string interceptedEvent)
        {
            return GetNextEvent(interceptedState, interceptedEvent) ?? TransitionInterceptor.defaultEvent;
        }

    }
}