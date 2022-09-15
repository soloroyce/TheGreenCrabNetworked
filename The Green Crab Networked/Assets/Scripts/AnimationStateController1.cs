using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController1 : MonoBehaviour
{
    public float speed = .05f;
    Animator animator;
    private Transform character;
    private float thrust;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        character = GetComponent<Transform>();
     
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

        bool flyUp = animator.GetBool("flyUp");
        bool qPressed = Input.GetKey("q");

        bool flyDown = animator.GetBool("flyDown");
        bool ePressed = Input.GetKey("e");

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

        if (!flyUp && qPressed)
           {
                animator.SetBool("flyUp", true);
            }
        if (flyUp && !qPressed)
           {
                animator.SetBool("flyUp", false);
           }

        if (!flyDown && ePressed)
           {
                animator.SetBool("flyDown", true);
           }
        if (flyDown && !ePressed)
           {
            animator.SetBool("flyDown", false);
           }

        if (Input.GetKey(KeyCode.Q))
            {
            character.Translate(Vector3.up * Time.deltaTime * thrust);
            }
        if (Input.GetKey(KeyCode.E))
            {character.Translate(Vector3.down * Time.deltaTime * thrust);
            }

        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
        float zDirection = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = new Vector3(xDirection, zDirection, yDirection);

        transform.position += moveDirection * speed;

        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }

    }

}


