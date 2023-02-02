using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public float rotationSpeed;
    public AudioClip pickAxeGrunt;
    public bool audioPlaying = false;
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


        if (direction != Vector3.zero)
        {
            transform.forward = direction;
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            transform.Translate(direction * speed * Time.deltaTime, Space.World);

            float targetAngle = Mathf.Atan2(direction.x, direction.z);
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(direction * speed * Time.deltaTime);

            animator.SetBool("IsWalking?", true);
        }

        else
        {
            animator.SetBool("IsWalking?", false);
        }


        if (Input.GetMouseButtonDown(0))
        {
            axeSwing();
        }

        else
        {
            animator.SetBool("IsSwinging?", false);

        }


    }




    private void axeSwing()
    {
        animator.SetBool("IsSwinging?", true);
        audioPlaying = true;
        if (audioPlaying == true)
        {
            Invoke("gruntSound", 1.2f);
        }
    }

    void gruntSound()
    {

        //audioPlaying = true;    
        AudioSource swinging = GetComponent<AudioSource>();
        swinging.PlayOneShot(pickAxeGrunt);
        audioPlaying = false;
        //Invoke("gruntSoundDelay", 2f);
        //gruntSound();

    }


    //void gruntSoundDelay()
    //{
    //audioPlaying = false;
    //}
}
