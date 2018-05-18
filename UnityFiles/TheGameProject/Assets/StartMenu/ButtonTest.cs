using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTest : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene");
    }

    //public void QuitGame()
    //{
    //    Debug.Log("QUIT!");
    //    Application.Quit();
    //}

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void ScoreBoard()
    {
        SceneManager.LoadScene("ScoreBoards");
    }
}
