using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;
    public Transform fence;
    private Vector3 nextFence;
    private int randx;

    void Start()
    {
       
        nextTileSpawn.z = 51;
        StartCoroutine(spawnTile());
    }


    void Update()
    {

    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        randx = Random.Range(-2,4);
        nextFence = nextTileSpawn;
        nextFence.x = randx;
        nextFence.y = 0;
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        Instantiate(fence, nextFence, fence.rotation);
        nextTileSpawn.z += 50;
        StartCoroutine(spawnTile());
    }
   
}
