using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Panel : MonoBehaviour
{
    public GameObject PausePanel;

    void Start()
    {
        PausePanel.SetActive(false);    
    }

    public void PauseButtonClick()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void res()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GamePlay");
    }

    public void GameStartGo()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameStart");
    }
}
