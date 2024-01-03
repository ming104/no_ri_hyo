using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endingtext : MonoBehaviour
{
    public int click;
    public Text Endtext;

    // Start is called before the first frame update
    void Start()
    {
        click = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            click++;
        }
        if(click == 0)
        {
            Endtext.GetComponent<Text>().text = "누리효는 안전하게 우주로 \n도착하는데 성공하였다.....";
        }
        if (click == 1)
        {
            Endtext.GetComponent<Text>().text = "누리효는 비록 여러번 날아올랐지만\n실패를 거듭했다 하지만 결국엔 성공하였다...";
        }
        if (click == 2)
        {
            Endtext.GetComponent<Text>().text = "지금까지 플레이해주셔서 감사합니다.";
        }
        if (click == 3)
        {
            Endtext.GetComponent<Text>().text = "다시 한번더 감사합니다.";
        }
        if (click == 4)
        {
            Endtext.GetComponent<Text>().text = "\"기록모드 열림\"";
        }
        if (click == 5)
        {
            PlayerPrefs.SetInt("girokon", 1);
            SceneManager.LoadScene("GameStart");
        }
    }
}
