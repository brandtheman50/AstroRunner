using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInv : MonoBehaviour
{
    private static int cubeSpeed = 20;
    void Start()
    {
        StartCoroutine(moveSpeed());
    }
    IEnumerator moveSpeed()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, cubeSpeed);
    }

    
    void Update()
    {
        
    }
}
