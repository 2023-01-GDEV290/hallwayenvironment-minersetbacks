using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public float rotationSpeed;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    private Animator animator;

    // Update is called once per frame

    void Start()
    {

        animator = GetComponent<Animator>();


    }
    
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {

            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime); 
            
            float targetAngle = Mathf.Atan2(direction.x, direction.z);
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(direction * speed * Time.deltaTime);

            animator.SetBool("IsWalking?", true);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                axeSwing();
            }

        }
        else 
        {

            animator.SetBool("IsWalking?", false);
        
        }
    }




    private void axeSwing()
    {
       animator.SetTrigger("IsSwinging?");
    }

   


}
