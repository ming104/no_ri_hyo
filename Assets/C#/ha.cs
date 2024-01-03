using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ha : MonoBehaviour
{
    public AudioSource haunjobikai;
    public AudioSource yagibunjotta;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0, 52) > 49)
        {
            haunjobikai.Play();
        }
        else
        {
            yagibunjotta.Play();
        }
    }
}
