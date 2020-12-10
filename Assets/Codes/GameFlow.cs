using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public static GameFlow instance = null;

    public Transform tileObj;
    private Vector3 nextTileSpawn;
    public Transform fence;
    private Vector3 nextFence;
    private int randx;
    private int random;
    public Transform pole;
    private Vector3 nextPole;
    public Transform tube;
    private Vector3 nextTube;
    public Transform coinObj;
    private Vector3 nextCoin;
    public Transform oxygen;
    private Vector3 nextTank;
    private int oxygenSpawn = 0;

    [SerializeField]
    Text YourScoreText;

    public int yourScore = 0;

    public static bool gameStopped;

    float nextScoreIncrease = 0f;

    public static int totalCoins = 0;

    void Start()
    {

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        yourScore = 0;

        gameStopped = false;

        nextTileSpawn.z = 40;
        StartCoroutine(spawnTile());
    }


    void Update()
    {
        if (gameStopped == false)
            IncreaseYourScore();

        YourScoreText.text = "Your Score: " + yourScore;
    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(0);
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        random = Random.Range(0, 5);
        if(random == 0)
        {
            randx = Random.Range(-2, 4);
            nextPole.z = nextTileSpawn.z;
            nextPole.y = 0f;
            nextPole.x = randx;
            Instantiate(pole, nextPole, pole.rotation);
        }
        
        
        else if (random == 1)
        {
            randx = Random.Range(-2, 4);
            nextFence = nextTileSpawn;
            nextFence.x = randx;
            nextFence.y = 0;
            
            Instantiate(fence, nextFence, fence.rotation);
        }

        else if (random == 2)
        {
            randx = Random.Range(-2, 4);
            nextTube.z = nextTileSpawn.z;
            nextTube.y = 0f;
            nextTube.x = randx;
            Instantiate(tube, nextTube, tube.rotation);
        }
        else if (random == 3)
        {
            randx = Random.Range(-2, 4);
            nextCoin.z = nextTileSpawn.z;
            nextCoin.y = 1f;
            nextCoin.x = randx;
            Instantiate(coinObj, nextCoin, coinObj.rotation);
        }

        if (oxygenSpawn == 20)
        {
            nextTank.z = nextTileSpawn.z - 25;
            nextTank.y = 0f;
            nextTank.x = Random.Range(-2, 4);
            Instantiate(oxygen, nextTank, oxygen.rotation);
            oxygenSpawn = 0;
        }
        oxygenSpawn += 1;
        nextTileSpawn.z += 10;
        StartCoroutine(spawnTile());
    }
    
    public void RunnerHit()
    {
        Time.timeScale = 0;
        gameStopped = true;
    }

    void IncreaseYourScore()
    {
        if (Time.unscaledTime > nextScoreIncrease)
        {
            yourScore += 1;
            nextScoreIncrease = Time.unscaledTime + 1;
        }
    }

}
