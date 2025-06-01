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
}