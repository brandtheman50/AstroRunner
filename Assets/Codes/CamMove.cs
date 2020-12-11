using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public static int camMovement = 20;

    void Start()
    {
        StartCoroutine(camSpeed());
    }

    void Update()
    {
        if(camMovement == 10)
        {
            StopCoroutine(camSpeed());
            StartCoroutine(slow());
        }
        else
        {
            StopCoroutine(slow());
            StartCoroutine(camSpeed());
            
        }
        if(GameFlow.gameStopped == true)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        
    }
    IEnumerator camSpeed()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, camMovement);
        
        
    }
    IEnumerator slow()
    {
         GetComponent<Rigidbody>().velocity = new Vector3(0, 0, camMovement);
         yield return new WaitForSeconds(1);
         camMovement = 20;
        
    }
    
}
