using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("girokmode");
    }

    public void Restart5min()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("GameStart");
    }
}
