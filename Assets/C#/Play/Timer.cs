using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float time;
    public static float sec;
    public static float min;
    public float TC = 0; 

    private void Start()
    {
        TC = 0;
        {
            StartCoroutine("StopWatch");
        }
    }
    IEnumerator StopWatch()
    {
        while (true)
        {
            time += Time.deltaTime;
            sec = (int)(time % 60);
            min = (int)(time / 60 % 60);

            timer.text = string.Format("Timer : {0:00}:{1:00}", min, sec);

            yield return null;
        }
    }

    void Update()
    {
        if (TC < 1)
        {
            TC += Time.deltaTime / 100;
        }
        timer.color = new Color(TC, TC, TC, 1);
        if(time >= 300)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}