using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girokmode : MonoBehaviour
{
    public GameObject rirok;
    public GameObject sijak;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("girokon") == 1) 
        {
            rirok.SetActive(true);
            rirok.transform.position = new Vector3(220, -603, 0);
            sijak.transform.position = new Vector3(-220, -603, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
