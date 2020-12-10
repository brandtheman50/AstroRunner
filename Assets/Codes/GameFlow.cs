using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;
    public Transform fence;
    private Vector3 nextFence;
    private int randx;
    public Transform pole;
    private Vector3 nextPole;
    public Transform tube;
    private Vector3 nextTube;

    [SerializeField]
    Text YourScoreText;

    int yourScore = 0;

    void Start()
    {
        yourScore = 0;

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

        randx = Random.Range(-2, 4);
        nextPole.z = nextTileSpawn.z-20;
        nextPole.y = 0f;
        nextPole.x = randx;
        Instantiate(pole, nextPole, pole.rotation);

        

        randx = Random.Range(-2, 4);
        nextTube.z = nextTileSpawn.z - 30;
        nextTube.y = 0f;
        nextTube.x = randx;
        Instantiate(tube, nextTube, tube.rotation);
        StartCoroutine(spawnTile());
    }
   
}
