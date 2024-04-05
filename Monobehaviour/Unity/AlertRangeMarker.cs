namespace Satchel
{
    /// <summary>
    /// Mark the gameObject to have an alert range added to it after being loaded from an asset bundle
    /// </summary>
    public class AlertRangeMarker : MonoBehaviour
    {

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