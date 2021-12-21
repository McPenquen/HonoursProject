using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Active Perspective")]
    [SerializeField] private bool is1stPP = true;
    [Header("Movement Variables")]
    [SerializeField] private int movementSpeed = 10;
    [SerializeField] private int rotationSpeed = 5;
    [SerializeField] private float jumpForce = 10.0f;

    [Header("Object References")]
    [SerializeField] private GameObject cam = null; // camera
    private Rigidbody rb = null;
    
    // The player is can jump - is touching the floor/and object with feet
    private bool canJump = false;

     void Start()
    {
        // Save the cam reference
        cam = transform.GetChild(0).gameObject;
        // Save rigid body reference
        rb = GetComponent<Rigidbody>();
        // Save the perspective
        is1stPP = GameManager.GetIs1stPP();
    }

    void Update()
    {
        // Detect movement
        DetectInput();
    }

     // Detect Movement and move
    public void DetectInput()
    {
        // Detect input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float mouseXInput = Input.GetAxis("Mouse X");
        float mouseYInput = Input.GetAxis("Mouse Y");
        float jumpInput = Input.GetAxis("Jump");

        // Adjust the forward and side vectors to 2D
        Vector3 twoDForward = cam.transform.forward;
        Vector3 twoDSide = Vector3.Cross(cam.transform.forward, transform.up);
        twoDForward.y = 0;
        twoDSide.y = 0;

        // Get the new position
        Vector3 newPosition = transform.position 
            + twoDForward.normalized * movementSpeed * Time.deltaTime * verticalInput
            + - twoDSide.normalized * movementSpeed * Time.deltaTime * horizontalInput;

        // Move the object to the new position
        //rb.MovePosition(newPosition);
        transform.position = newPosition;    

        cam.transform.Rotate(-mouseYInput * rotationSpeed, mouseXInput * rotationSpeed, 0);
        // Freeze the z-axis rotation
        Vector3 currentAngles = cam.transform.eulerAngles;
        cam.transform.eulerAngles = new Vector3(currentAngles.x, currentAngles.y, 0); 
    
        // Detect jumping
        if (jumpInput != 0 && canJump)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
    // Set the jumping to a bool
    public void SetCanJump(bool b)
    {
        canJump = b;
    }

}
