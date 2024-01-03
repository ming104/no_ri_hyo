using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int Trans;
    public GameObject NoRiHo;

    void Start()
    {
        Trans = 0;
        NoRiHo.transform.position = new Vector3(0, -0.5f, 0);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if (Trans > -1)
            {
                Trans--;
                NoRiHo.transform.Translate(new Vector3(-2, 0, 0));
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Trans < 1)
            {
                Trans++;
                NoRiHo.transform.Translate(new Vector3(2, 0, 0));
            }
        }
    }
    public void RightButton()
    {
        if (Trans < 1)
        {
            Trans++;
            NoRiHo.transform.Translate (new Vector3(2, 0, 0));
        }
    }
    
    public void leftButton()
    {
        if (Trans > -1)
        {
            Trans--;
            NoRiHo.transform.Translate(new Vector3(-2, 0, 0));
        }
    }
}
