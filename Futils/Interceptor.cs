namespace Satchel.Futils
{
    public class InterceptorAction : FsmStateAction{
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
    public class EventInterceptor{
        public string fromState;
        public string eventName;
        public Func<bool> shouldIntercept = () => true;
        public Action onIntercept;

    }
    public class TransitionInterceptor{
        public string fromState;
        public string eventName;
        public string toStateDefault;
        public string toStateCustom;
        public Func<bool> shouldIntercept = () => true;
        public Action<string,string> onIntercept;
        public static string defaultEvent = "Intercept-DEFAULT";
        public static string customEvent = "Intercept-CUSTOM";
        public string GetNextEvent(string interceptedState,string interceptedEvent){ 
            if(shouldIntercept != null && shouldIntercept()){
                if(onIntercept != null){
                    onIntercept(interceptedState,interceptedEvent);
                }
                return TransitionInterceptor.customEvent;
            }  
            return TransitionInterceptor.defaultEvent;
        }
        public string GetNextEventOrDefault(string interceptedState,string interceptedEvent){
            return GetNextEvent(interceptedState,interceptedEvent) ?? TransitionInterceptor.defaultEvent; 
        }

    }
    public static class InterceptorExtensions{
        public static void Intercept(this PlayMakerFSM fsm, TransitionInterceptor interceptor){
           var interceptorName = $"Satchel_Intercept_{interceptor.fromState}_{interceptor.eventName}";
           var interceptionState = new FsmState(fsm.Fsm){Name=interceptorName};
           interceptionState.InsertAction(new InterceptorAction(){
               method = () => interceptor.GetNextEventOrDefault(interceptor.fromState,interceptor.eventName)
            },0);
           fsm.AddState(interceptionState);
           fsm.ChangeTransition(interceptor.fromState,interceptor.eventName,interceptorName);
           fsm.AddTransition(interceptorName,TransitionInterceptor.defaultEvent,interceptor.toStateDefault);
           fsm.AddTransition(interceptorName,TransitionInterceptor.customEvent,interceptor.toStateCustom);
        }

        public static void Intercept(this PlayMakerFSM fsm, EventInterceptor interceptor){
            var interceptorName = $"Intercept_Event_{interceptor.fromState}_{interceptor.eventName}";
            var interceptionState = new FsmState(fsm.Fsm){Name=interceptorName};
                interceptionState.InsertAction(new InterceptorAction(){
                    method = () => {
                        if(interceptor.shouldIntercept != null && interceptor.shouldIntercept()){
                            interceptor.onIntercept();
                        }
                        return $"back to {interceptor.fromState}";
                    }
                },0);
                fsm.AddState(interceptionState);
                fsm.AddTransition(interceptor.fromState,interceptor.eventName,interceptorName);
                fsm.AddTransition(interceptorName,$"back to {interceptor.fromState}",interceptor.fromState);
        }
    }
}