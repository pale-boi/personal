using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraX : MonoBehaviour
{
    public float sensitivity = 2.0f; // Mouse sensitivity
    public float minYAngle = -60.0f; // Minimum Y angle
    public float maxYAngle = 60.0f; // Maximum Y angle

    private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Lock the cursor to the center of the game window
        Cursor.lockState = CursorLockMode.Locked;
        // Hide the cursor
        Cursor.visible = false;

        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse movement
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate the camera horizontally based on mouse movement
        transform.Rotate(0f, mouseX, 0f, Space.World);

        // Rotate the camera vertically based on mouse movement
        cameraTransform.Rotate(-mouseY, 0f, 0f);

        // Unlock the cursor if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
