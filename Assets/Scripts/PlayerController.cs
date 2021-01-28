using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Public Variables
    public float speed; // Speed for hot red vehicle
    public float turnSpeed; // Rotationspeed for hot red vehicle
    private float horizontalInput; // Input for arrow keys left and right
    private float verticalInput; // Input of arrow keys up and down



    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        // Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        //INPUT FOR RIGIDBODY MOVEMENT

        // if (Input.GetKey("w"))
        {
            //rb.velocity = transform.forward * speed;
        }
        //if (Input.GetKey("s"))
        {
            //rb.velocity = -transform.forward * speed;
        }



        // Speed the shit outta Pallet Town with your car using forward, backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (verticalInput != 0)
        {
            // If TRUE, e.g. if up or down arrow keys are pressed, do:
            //Turn our hot red vehicle, when pressing left and right keys
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput, Space.Self); 

            Debug.Log("Vertical Input ist größer als Null!" + verticalInput + "Interessant!");
            Debug.Log(verticalInput);
        }
        else
        {
            // If FALSE, e.g. if up or down keys are NOT pressed:
            Debug.Log("Vertical Input ist gleich NULL!" + verticalInput);
        }
    }
}
