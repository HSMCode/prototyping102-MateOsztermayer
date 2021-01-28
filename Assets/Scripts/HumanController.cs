using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour
{
    private Rigidbody _humanRb;
    public float jumpForce = 10f;
    public float gravityModifer;
    public bool isOnGround = true;



    // Start is called before the first frame update
    void Start()
    {
        _humanRb = GetComponent<Rigidbody>();
        Physics.gravity = Physics.gravity * gravityModifer;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _humanRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
