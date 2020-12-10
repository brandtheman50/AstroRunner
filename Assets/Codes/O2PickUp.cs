using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2PickUp : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 5, 0);
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameFlow.o2 += 30;
            Destroy(gameObject);
        }
    }
}
