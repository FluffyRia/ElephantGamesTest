using Spine;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof (Animator))]
    public class StartAnimationOnClick : MonoBehaviour
    {
        private Animator _animator;

        private void OnValidate()
        {
            _animator ??= GetComponent<Animator>();
        }

        private void Start()
        {
            // Get the Animator component from the parent object
            _animator = transform.parent.GetComponent<Animator>();
        }

        private void OnMouseDown()
        {
            // Check if the Animator component exists and is not null and play animation
            if (_animator != null) _animator.SetTrigger("PlayAnimation");
        }
    }
}