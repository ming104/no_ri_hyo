using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qu : MonoBehaviour
{
    public GameObject QusButton;
    // Start is called before the first frame update
    void Start()
    {
        QusButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QButton()
    {
        QusButton.SetActive(true);
    }

    public void exit()
    {
        QusButton.SetActive(false);
    }
}
