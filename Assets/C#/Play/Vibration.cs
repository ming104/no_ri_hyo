using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vibration : MonoBehaviour
{
    public GameObject VibrationON;
    public GameObject VibrationOFF;

    public static bool VibrationOn;

    void Start()
    {
        if(!PlayerPrefs.HasKey("VibrationON"))
        {
            PlayerPrefs.SetInt("VibrationON", 1);
        }
      
        if (PlayerPrefs.GetInt("VibrationON") == 1)
        {
            VibrationON.SetActive(true);
            VibrationOFF.SetActive(false);
            VibrationOn = true;
        }
        if (PlayerPrefs.GetInt("VibrationON") == 0)
        {
            VibrationON.SetActive(false);
            VibrationOFF.SetActive(true);
            VibrationOn = false;
        }
    }

    public void VibrON()
    {
        VibrationON.SetActive(false);
        VibrationOFF.SetActive(true);
        VibrationOn = false;
        PlayerPrefs.SetInt("VibrationON", 0);
    }
    public void VibrOFF()
    {
        VibrationON.SetActive(true);
        VibrationOFF.SetActive(false);
        VibrationOn = true;
        PlayerPrefs.SetInt("VibrationON", 1);
    }
   
}
