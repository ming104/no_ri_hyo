using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public GameObject SoundOn;
    public GameObject SoundOff;
    public AudioSource UPUP;

    void Start()
    {
        if(!PlayerPrefs.HasKey("SoundON"))
        {
            PlayerPrefs.SetInt("SoundON", 1);
        }
      
        if (PlayerPrefs.GetInt("SoundON") == 1)
        {
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
            UPUP.mute = false;
        }
        if (PlayerPrefs.GetInt("SoundON") == 0)
        {
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
            UPUP.mute = true;
        }
    }

    public void SoundON()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
        UPUP.mute = true;
        PlayerPrefs.SetInt("SoundON", 0);
    }
    public void SoundOFF()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        UPUP.mute = false;
        PlayerPrefs.SetInt("SoundON", 1);
    }
   
}
