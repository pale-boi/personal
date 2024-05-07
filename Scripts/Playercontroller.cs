using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private GameObject focalPoint;
    public GameObject ArmL;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focal point");
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Mouse1))
        {
            ArmL.SetActive(true);
        }
       else
        {
            ArmL.SetActive(false);
        }
        
        // Get input for movement
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        // Calculate forward movement
        Vector3 movement = transform.forward * speed * Time.deltaTime * VerticalInput;
        Vector3 Movement = transform.right * speed * Time.deltaTime * HorizontalInput;
        // Apply movement to the character's position
        transform.position += movement;
        transform.position += Movement;

    }
}
