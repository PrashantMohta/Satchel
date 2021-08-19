using Modding;
using UnityEngine;

namespace DandyCore{
    public class WhoAmI : MonoBehaviour{
        private void Awake() {
            Modding.Logger.Log("v2 Type: " + this.GetType().AssemblyQualifiedName);
        }
    }
}