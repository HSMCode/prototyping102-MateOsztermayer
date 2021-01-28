using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningTires : MonoBehaviour
{
    public GameObject tire;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnTire", startDelay, spawnInterval);
    }



    void spawnTire()
    {
        Instantiate(tire, this.transform.position, tire.transform.rotation);
    }
}
