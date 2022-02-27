namespace Satchel
{
    public class WhoAmI : MonoBehaviour{
        private void Awake() {
            Modding.Logger.Log("v2 Type: " + this.GetType().AssemblyQualifiedName);
        }
    }
}