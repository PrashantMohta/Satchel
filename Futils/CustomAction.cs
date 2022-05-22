namespace Satchel.Futils
{
    /// <summary>
    /// An FsmStateAction that executes a method when used
    /// </summary>
    public class CustomFsmAction : FsmStateAction{
        public Action method;
        public override void Reset()
        {
            method = null;
            base.Reset();
        }

        public override void OnEnter()
        {
            method?.Invoke();
            Finish();
        }
    }

}