using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    public Rigidbody pickUp;
    public int spawnRate;
    void Start()
    {
        pickUp.angularVelocity = new Vector3(0, 5, 0);
    }

    
    void Update()
    {
        
    }
}
