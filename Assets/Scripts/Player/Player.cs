using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement Variables")]
    [SerializeField] private int movementSpeed = 10;
    [SerializeField] private int rotationSpeed = 5;

    [Header("Object References")]
    [SerializeField] private GameObject cam = null;
    [SerializeField] private GameObject feet = null;
    
    // The player is can jump - is touching the floor/and object with feet
    private bool canJump = false;

     void Start()
    {
        // Save the cam reference
        cam = transform.GetChild(0).gameObject;
        // Save the feet reference
        feet = transform.GetChild(1).gameObject;
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

        // If we detect a motion input lets move
        if (horizontalInput != 0 || verticalInput != 0)
        {
            // Adjust the forward and side vectors to 2D
            Vector3 twoDForward = cam.transform.forward;
            Vector3 twoDSide = Vector3.Cross(cam.transform.forward, transform.up);
            twoDForward.y = 0;
            twoDSide.y = 0;

            // Get the new position
            Vector3 newPosition = transform.position  
                + twoDForward * movementSpeed * Time.deltaTime * verticalInput
                + - twoDSide * movementSpeed * Time.deltaTime * horizontalInput;

            // Move the object to the new position
            transform.position = newPosition;
        }

        // If we detect mouse input rotate the camera
        if (mouseXInput != 0 || mouseYInput != 0)
        {
            cam.transform.Rotate(-mouseYInput * rotationSpeed, mouseXInput * rotationSpeed, 0);
            // Freeze the z-axis rotation
            Vector3 currentAngles = cam.transform.eulerAngles;
            cam.transform.eulerAngles = new Vector3(currentAngles.x, currentAngles.y, 0); 
        }
    }

}
