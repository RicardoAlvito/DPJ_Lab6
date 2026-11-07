using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{



    public float moveSpeed;
    public float maxSpeed;
    public float jumpForce;
    public float groundCheckRadius;
    public float horizantallnput;
    private bool isGrounded = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizantallnput = Input.GetAxisRaw("Horizontal");
        if (Input.GetAxisRaw("Jump") == 1)
        {
            if (isGrounded == true)
            {
                Debug.Log(2);
                Jump();
            }
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        Vector3 Velocity = rb.linearVelocity;
        float targetVelX = horizantallnput * moveSpeed;
        float newVelx = Mathf.MoveTowards(Velocity.x,targetVelX,50f*Time.fixedDeltaTime);
        rb.linearVelocity = new Vector3(Mathf.Clamp(newVelx, -maxSpeed, maxSpeed), Velocity.y, 0f);
    }

    void Jump() { 
    Vector3 VelocityLRd = rb.linearVelocity;
        VelocityLRd.y = 0f;
        rb.linearVelocity = VelocityLRd;
        rb.AddForce(transform.up * jumpForce);
    }
}

