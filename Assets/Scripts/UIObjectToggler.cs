using UnityEngine;

namespace Assets.Scripts
{
    public class UIObjectToggler : MonoBehaviour
    {
        [field: SerializeField]
        public RectTransform ObjectToToggle { get; private set; } 

        private void Start()
        {
            // Ensure the specified object is initially turned off
            if (ObjectToToggle != null)
            {
                ObjectToToggle.gameObject.SetActive(false);
            }
        }

        private void OnMouseDown()
        {
            // Check if a GameObject is specified to toggle
            if (ObjectToToggle != null)
            {
                // Toggle the visibility of the specified object
                ObjectToToggle.gameObject.SetActive(!ObjectToToggle.gameObject.activeSelf);
            }
        }
    }
}