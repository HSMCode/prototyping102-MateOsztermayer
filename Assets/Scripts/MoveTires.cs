using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTires : MonoBehaviour
{
    public float lifetime = 10f;
    public GameObject tire;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyTire", lifetime);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.back * 35f * Time.deltaTime);

        transform.Rotate(Vector3.left * 30f * Time.deltaTime);
    }



    void destroyTire()
    {
        Destroy(tire);
    }
}
