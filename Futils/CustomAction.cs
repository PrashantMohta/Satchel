namespace Satchel.Futils
{
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