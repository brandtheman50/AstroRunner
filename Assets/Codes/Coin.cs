﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 10, 0);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameFlow.totalCoins += 1;
            GameFlow.yourScore += 1;
            
            Destroy(gameObject);
        }
    }
}
