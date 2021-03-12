using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    

    public void PlayAnimation()
    {
        GetComponent<Animator>().SetBool("BlastOff", true);
    }
}
