namespace Satchel.Futils
{

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