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
            Endtext.GetComponent<Text>().text = "����ȿ�� �����ϰ� ���ַ� \n�����ϴµ� �����Ͽ���.....";
        }
        if (click == 1)
        {
            Endtext.GetComponent<Text>().text = "����ȿ�� ��� ������ ���ƿö�����\n���и� �ŵ��ߴ� ������ �ᱹ�� �����Ͽ���...";
        }
        if (click == 2)
        {
            Endtext.GetComponent<Text>().text = "���ݱ��� �÷������ּż� �����մϴ�.";
        }
        if (click == 3)
        {
            Endtext.GetComponent<Text>().text = "�ٽ� �ѹ��� �����մϴ�.";
        }
        if (click == 4)
        {
            Endtext.GetComponent<Text>().text = "\"��ϸ�� ����\"";
        }
        if (click == 5)
        {
            PlayerPrefs.SetInt("girokon", 1);
            SceneManager.LoadScene("GameStart");
        }
    }
}
