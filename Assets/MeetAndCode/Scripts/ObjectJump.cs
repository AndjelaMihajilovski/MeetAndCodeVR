using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectJump : MonoBehaviour
{
    private Rigidbody rb;
    public bool isJumping = true;

    public float moveSpeed = 5.0f;
    public float jumpForce = 8.0f;
    public float gravity = 20.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Freeze rotation to prevent unwanted tilting
    }

    private void Update()
    {
        // Move the animal
        /* float horizontalInput = Input.GetAxis("Horizontal");
         float verticalInput = Input.GetAxis("Vertical");


         Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;


         transform.Translate(movement);*/

        // Jump
        if (Input.GetButtonDown("Jump") )
        {      
            Jump();
        }

    }

    public void Jump()
    {   
        // Apply gravity
        if (isJumping)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rb.AddForce(Vector3.down * gravity);
            isJumping = false;
        }
  
        Debug.Log("JUMP");
    }


    private void OnTriggerEnter(Collider other)
    {
        // Check if the animal has landed on the ground
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
