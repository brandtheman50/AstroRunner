using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void LoadSceneByNumber(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }

    public void quitGame()
    {
        Debug.Log("quit called");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else  
        Application.Quit();
#endif
    }
}
