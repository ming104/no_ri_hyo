using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject GirokonPlayButton;
    public GameObject PlayButton;
    void Awake()
    {
        if (!PlayerPrefs.HasKey("girokon"))
        {
            PlayerPrefs.SetInt("girokon", 0);
        }
        if(PlayerPrefs.GetInt("girokon") == 0)
        {
            GirokonPlayButton.SetActive(false);
            PlayButton.transform.position = new Vector3(550, 450, 0);
        }
    }

    public void GameSt()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void Game_girok()
    {
        SceneManager.LoadScene("girokmode");
    }
}
