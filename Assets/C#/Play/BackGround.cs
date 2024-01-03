using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    public SpriteRenderer Back1;
    public GameObject Back2;
    public float Tim = 0;
    // Start is called before the first frame update
    void Start()
    {
        Tim = 1;
        Back2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Tim > 0)
        {
            Tim -= Time.deltaTime / 100;
        }
        if(Tim < 0)
        {
            Back2?.SetActive(false);
        }
        
        Back1.color = new Color(Tim, Tim, Tim, 1);
    }
}
