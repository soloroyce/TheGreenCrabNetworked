using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController1 : MonoBehaviour
{
    public float speed = .05f;
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

        bool flyRight =animator.GetBool("flyRight");
        bool rightPressed = Input.GetKey("d");

        bool flyLeft = animator.GetBool("flyLeft");
        bool leftPressed = Input.GetKey("a");

        bool flyBack = animator.GetBool("flyBack");
        bool backPressed = Input.GetKey("s");

        bool willSpin = animator.GetBool("willSpin");
        bool qPressed = Input.GetKey("q");

    
        if (!isWalking && forwardPressed)
            {
                animator.SetBool("isWalking", true);
            }

        if (isWalking && !forwardPressed)
            {
                animator.SetBool("isWalking", false);
            }

  
        if (!flyRight && rightPressed)
            {
                animator.SetBool("flyRight", true);
            }
        if (flyRight && !rightPressed)
            {
                animator.SetBool("flyRight", false);
            }
        if (!flyLeft && leftPressed)
            {
                animator.SetBool("flyLeft", true);
            }
        if (flyLeft && !leftPressed)
            {
                animator.SetBool("flyLeft", false);
            }
        
        if (!flyBack && backPressed)
            {
                animator.SetBool("flyBack", true);
            }
        if(flyBack && !backPressed)
            {
                animator.SetBool("flyBack", false);
            }

        if (!willSpin && qPressed)
            {
            animator.SetBool("willSpin", true);
            }
        if (willSpin && !qPressed)
            {
            animator.SetBool("willSpin", false);
            }

        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed;

        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }

    }

}


