namespace Satchel.Futils
{

    /// <summary>
    /// Interceptions
    /// </summary>
    public static class InterceptorExtensions
    {

        /// <summary>
        /// Check if an TransitionInterceptor is applied
        /// </summary>
        /// <param name="fsm"></param>
        /// <param name="interceptor"></param>
        /// <returns></returns>
        public static bool HasIntercept(this PlayMakerFSM fsm, TransitionInterceptor interceptor)
        {
            var interceptorName = $"Satchel_Intercept_{interceptor.fromState}_{interceptor.eventName}";
            return fsm.TryGetState(interceptorName, out var state);
        }

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
        /// Reverse  a previously applied TransitionInterceptor
        /// </summary>
        /// <param name="fsm"></param>
        /// <param name="interceptor"></param>
        public static void Reverse(this PlayMakerFSM fsm, TransitionInterceptor interceptor)
        {

            var interceptorName = $"Satchel_Intercept_{interceptor.fromState}_{interceptor.eventName}";

            if (fsm.TryGetState(interceptorName, out var state))
            {
                //reset transtion
                fsm.ChangeTransition(interceptor.fromState, interceptor.eventName, interceptor.toStateDefault);

                // remove connections
                fsm.RemoveTransition(interceptorName, TransitionInterceptor.defaultEvent);
                fsm.RemoveTransition(interceptorName, TransitionInterceptor.customEvent);

                // remove state
                fsm.RemoveState(state.Name);
            }
            else
            {
                throw new ArgumentException($"FSM \"{fsm.FsmName}\" does not have state \"{interceptorName}\"");
            }
        }


        /// <summary>
        /// Check if an EventInterceptor is applied
        /// </summary>
        /// <param name="fsm"></param>
        /// <param name="interceptor"></param>
        /// <returns></returns>
        public static bool HasIntercept(this PlayMakerFSM fsm, EventInterceptor interceptor)
        {
            var interceptorName = $"Intercept_Event_{interceptor.fromState}_{interceptor.eventName}";
            return fsm.TryGetState(interceptorName, out var state);
        }

        /// <summary>
        /// Intercept an Event on an FSM; Runs a lambda on event if enabled and re-lands on the same state.
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

        /// <summary>
        /// Reverse a previously applied EventInterceptor
        /// </summary>
        /// <param name="fsm"></param>
        /// <param name="interceptor"></param>
        public static void Reverse(this PlayMakerFSM fsm, EventInterceptor interceptor)
        {
            var interceptorName = $"Intercept_Event_{interceptor.fromState}_{interceptor.eventName}";

            if (fsm.TryGetState(interceptorName, out var state))
            {
                // remove connections
                fsm.RemoveTransition(interceptor.fromState, interceptor.eventName);
                fsm.RemoveTransition(interceptorName, $"back to {interceptor.fromState}");

                // remove state
                fsm.RemoveState(state.Name);
            }
            else
            {
                throw new ArgumentException($"FSM \"{fsm.FsmName}\" does not have state \"{interceptorName}\"");
            }

        }
    }
}