using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableCollider : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Get the Animator component attached to the object
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        // Check if the Animator component exists and is not null
        if (animator != null)
        {
            // Trigger the animation (assuming you have a trigger parameter named "PlayAnimation")
            animator.SetTrigger("PlayAnimation");
        }
    }
}
