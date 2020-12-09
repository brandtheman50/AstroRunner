using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;

    void Start()
    {
        nextTileSpawn.z = 50;
        StartCoroutine(spawnTile());
    }


    void Update()
    {

    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        nextTileSpawn.z += 100;
        StartCoroutine(spawnTile());
    }
}
