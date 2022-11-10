using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float jumpHeight;
    private Rigidbody rb;
    private Vector2 direction;
    
    
    
    [Header("Ground Check")]
    public bool isGrounded;//Are we able to jump 
    public Transform groundCheck; //Are we tuching the ground
    public float groundCheckRadius; //Making an area to cheak ground
    public LayerMask whatIsGround; //What is the ground
    private float moveVelocity;

    private Vector3 velocity;
    public float gravity = -9.81f;

    public bool IsGrounded
    {
        get => isGrounded;
        set => isGrounded = value;
    }
    private void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        
        
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, whatIsGround);
        if (Input.GetMouseButton(0) && isGrounded)
                {
                    Jump();
                }
        
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                
            }
        }*/
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        //rb.AddForce(Vector2.up * jumpHeight);
    }
}
