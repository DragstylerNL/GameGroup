using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MenuButtons : MonoBehaviour {

    public GameObject vid;
    public GameObject vidPlayer;
    private VideoPlayer vidP;
    private bool update = false;

    public void PlayGameFromStart()
    {
        vid.SetActive(true);
        vidP = vidPlayer.GetComponent<VideoPlayer>();
        vidP.Play();
        update = true;
    }
    void Update()
    {
        if (update)
        {
            if (vidP.time >= 21.1d)
            {
                PlayGame();
            }
        }
    }


    public void PlayGame(){


        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
