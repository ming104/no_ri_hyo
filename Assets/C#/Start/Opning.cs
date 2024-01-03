using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opning : MonoBehaviour
{
    public GameObject norihyo;
    public GameObject Start_Panel;
    // Start is called before the first frame update
    void Start()
    {
        Start_Panel.SetActive(false);
        Invoke("norihyodis", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void norihyodis()
    {
        norihyo.SetActive(false);
        Start_Panel.SetActive(true);

    }
}
