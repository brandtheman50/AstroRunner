using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoopthruScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        DontDestroyOnLoad(this.gameObject);
    }
    void Destry()
    {
        Destroy(this.gameObject);
    }
}
