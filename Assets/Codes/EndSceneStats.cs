using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneStats : MonoBehaviour
{
    [SerializeField]
    Text YourScoreText;
    [SerializeField]
    Text HighScoreText;
    [SerializeField]
    Text CoinCollectedText;

    // Start is called before the first frame update
    void Start()
    {
        YourScoreText.text = "Your Score: " + GameFlow.yourScore;
        HighScoreText.text = "High Score: " + GameFlow.highScore;
        CoinCollectedText.text = "Coins Collected: " + GameFlow.totalCoins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
