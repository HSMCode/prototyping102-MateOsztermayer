using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningWheels : MonoBehaviour
{
    public float rotationspeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Vertical");

        if (Input.GetAxis("Vertical") > 0f)  
        {
            transform.Rotate(360f * Time.deltaTime * rotationspeed, 0, 0);
        }


        else if (Input.GetAxis("Vertical") < 0f)
        {
            transform.Rotate(-360f * Time.deltaTime * rotationspeed, 0, 0);
        }
    }
}
