using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Transform target;

    //offset from a local point of car to camera position
    private Vector3 offset = new Vector3(0, 5, -7);



    // Start is called before the first frame update
    void Start()
    {
        target = player.transform;
    }



    // Update is called once per frame
    void LateUpdate()
    {
        //set the camera to the position of the car with offset
        //transform.position = player.transform.position + offset;

        //set the camera to the position of the car with offset, converted to World Space
        transform.position = target.TransformPoint(offset);

        //Look at your car's transorm position
        transform.LookAt(target);
    }
}
