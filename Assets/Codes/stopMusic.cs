using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        foreach (GameObject bgm in objs)
            GameObject.Destroy(bgm);
    }
}
