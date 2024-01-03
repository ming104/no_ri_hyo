using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dis : MonoBehaviour
{
    public GameObject norihyo;
    public GameObject imageText;
    // Start is called before the first frame update
    void Start()
    {
        norihyo.SetActive(true);
        imageText.SetActive(false);
        Invoke("saf", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saf()
    {
        norihyo.SetActive(false);
        imageText.SetActive(true);
    }
}
