using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]
    Transform cameraTransform;
    [SerializeField]
    Vector2 cameraVec;
    Vector3 forces;
    public float currentForce;                 // amount of force for movement
    public float currentJumpForce;             // amount of force for jumping
    public float currentMaxSpeed;              // maximum speed that player can go
    float baseForce;
    float baseJumpForce;
    float baseMaxSpeed;
    bool onGround = true;                      // controls if player is on the ground or not


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        cameraVec = new Vector2(cameraTransform.forward.x, cameraTransform.forward.z).normalized;
        // apply movement via GetAxis
        float horizontal = Input.GetAxis("Horizontal") * cameraVec.x + Input.GetAxis("Vertical") * -cameraVec.y;
        float vertical = Input.GetAxis("Horizontal") * cameraVec.y + Input.GetAxis("Vertical") * cameraVec.x;

        float jump = 0;

        // detect if space is pressed
        if (Input.GetKeyDown("space"))
        {
            if (onGround)
                jump = Input.GetAxis("Jump") * currentJumpForce;
        }

        // move by time
        horizontal *= Time.deltaTime;
        vertical *= Time.deltaTime;

        forces = new Vector3(vertical, 0, -horizontal).normalized * currentForce;

        // apply force to player's rigidbody to make it move
        rb.AddForce(forces, ForceMode.Force);
        rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
        if (rb.velocity.magnitude > currentMaxSpeed)
        {
            rb.velocity = rb.velocity.normalized * currentMaxSpeed;
        }
	}

    private void OnCollisionStay(Collision collision)
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
