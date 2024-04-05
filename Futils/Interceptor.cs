namespace Satchel.Futils
{
    /// <summary>
    /// an Action that invokes a method to raise an event based on the method
    /// </summary>
    public class InterceptorAction : FsmStateAction
    {
        public Func<string> method;
        public override void Reset()
        {
            method = null;
            base.Reset();
        }

        public override void OnEnter()
        {
            base.Fsm.Event(method?.Invoke());
            Finish();
        }
    }

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

    /// <summary>
    /// Interceptions
    /// </summary>
    public static class InterceptorExtensions
    {
        /// <summary>
        /// Intercept a transition on an FSM
        /// </summary>
        /// <param name="fsm"></param>
        /// <param name="interceptor"></param>
        public static void Intercept(this PlayMakerFSM fsm, TransitionInterceptor interceptor)
        {
            var interceptorName = $"Satchel_Intercept_{interceptor.fromState}_{interceptor.eventName}";
            var interceptionState = new FsmState(fsm.Fsm) { Name = interceptorName };
            interceptionState.InsertAction(new InterceptorAction()
            {
                method = () => interceptor.GetNextEventOrDefault(interceptor.fromState, interceptor.eventName)
            }, 0);
            fsm.AddState(interceptionState);
            fsm.ChangeTransition(interceptor.fromState, interceptor.eventName, interceptorName);
            fsm.AddTransition(interceptorName, TransitionInterceptor.defaultEvent, interceptor.toStateDefault);
            fsm.AddTransition(interceptorName, TransitionInterceptor.customEvent, interceptor.toStateCustom);
        }
        /// <summary>
        /// Intercept an Event on an FSM
        /// </summary>
        /// <param name="fsm"></param>
        /// <param name="interceptor"></param>
        public static void Intercept(this PlayMakerFSM fsm, EventInterceptor interceptor)
        {
            var interceptorName = $"Intercept_Event_{interceptor.fromState}_{interceptor.eventName}";
            var interceptionState = new FsmState(fsm.Fsm) { Name = interceptorName };
            interceptionState.InsertAction(new InterceptorAction()
            {
                method = () =>
                {
                    if (interceptor.shouldIntercept != null && interceptor.shouldIntercept())
                    {
                        interceptor.onIntercept();
                    }
                    return $"back to {interceptor.fromState}";
                }
            }, 0);
            fsm.AddState(interceptionState);
            fsm.AddTransition(interceptor.fromState, interceptor.eventName, interceptorName);
            fsm.AddTransition(interceptorName, $"back to {interceptor.fromState}", interceptor.fromState);
        }
    }
}