using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonkAnimationController : MonoBehaviour
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
        
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, yDirection);

        transform.position += moveDirection * speed;

        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }

    }

}


