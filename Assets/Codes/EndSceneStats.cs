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

    // Start is called before the first frame update
    void Start()
    {
        YourScoreText.text = "Your Score: " + GameFlow.yourScore;
        HighScoreText.text = "High Score: " + GameFlow.highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
