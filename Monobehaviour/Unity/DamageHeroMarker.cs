namespace Satchel
{
    /// <summary>
    /// Mark this gameObject to be an Enemy after loading from an asset bundle
    /// </summary>
    public class DamageHeroMarker : MonoBehaviour
    {
        //this script just marks the go as one to add a damage hero to

        // damage hero
        public int damageDealt = 1;
        public int hazardType = 1;
        public bool shadowDashHazard;
        public bool resetOnEnable;

        // dont show in editer
        private bool processed = false;

        public bool isProcessed()
        {
            return processed;
        }
        public void setProcessed()
        {
            processed = true;
        }

    }
}