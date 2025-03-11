using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekerMovements : MonoBehaviour
{
    public AudioSource jump;

    private CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.18f * 2;
    public float jumpHeight = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;
    public bool isMoving;
    private Vector3 lastPosition = new Vector3(0f, 0f, 0f);

    void Start()
    {
        controller = GetComponent<CharacterController>();
//        jump = GetComponent<AudioSource>();
    }

        void Update()
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                jump.Play();

            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

            if (lastPosition != gameObject.transform.position && isGrounded)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }

            lastPosition = gameObject.transform.position;
        }
}
 