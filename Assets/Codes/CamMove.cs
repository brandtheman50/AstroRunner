using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{


    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 40);

    }

    void Update()
    {

    }
}
