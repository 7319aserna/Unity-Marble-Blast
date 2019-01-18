using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    Rigidbody rb;
    public float force;                 // amount of force for movement
    public float jumpForce;             // amount of force for jumping
    public float maxSpeed;              // maximum speed that player can go
    bool onGround = true;               // controls if player is on the ground or not


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // apply movement via GetAxis
        float horizontal = Input.GetAxis("Horizontal") * force;
        float vertical = Input.GetAxis("Vertical") * force;

        float jump = 0;

        // detect if space is pressed
        if (Input.GetKeyDown("space"))
        {
            if (onGround)
                jump = Input.GetAxis("Jump") * jumpForce;
        }

        // move by time
        horizontal *= Time.deltaTime;
        vertical *= Time.deltaTime;

        // apply force to player's rigidbody to make it move
        rb.AddForce(new Vector3(horizontal, jump, vertical), ForceMode.Impulse);
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        // if player is on ground
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // if player gets off of the ground
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
        }
    }
}
