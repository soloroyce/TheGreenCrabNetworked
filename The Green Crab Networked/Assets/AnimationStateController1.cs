using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController1 : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        bool isSpinning = Input.GetKey("left shift");
    
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (forwardPressed && isSpinning)
        {
            animator.SetBool("isSpinning", true);
         
        }
        if(!forwardPressed || !isSpinning)
        {
               animator.SetBool("isSpinning", false);
        }
    }
}


