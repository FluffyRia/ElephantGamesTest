using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof (Animator))]
    public class StartAnimationOnClick : MonoBehaviour
    {
        [SerializeField]
        private Animator _animator;

        private void OnValidate()
        {
            _animator ??= GetComponent<Animator>();
        }
        private void OnMouseDown()
        {
            // Check if the Animator component exists and is not null and play animation
            if (_animator != null) 
            {
                print("clicked");
                _animator.SetTrigger("PlayAnimation"); 
            }
        }
    }
}