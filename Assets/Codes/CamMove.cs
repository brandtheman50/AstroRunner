using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public static int camMovement = 20;

    void Start()
    {
        

    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, camMovement);
        
    }
}
