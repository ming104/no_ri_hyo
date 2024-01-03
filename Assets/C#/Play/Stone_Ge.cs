using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_Ge : MonoBehaviour
{
    public GameObject Stone1;
    public GameObject Stone2;
    public float Ti = 2;
    public float T = 1;
    public static float Gra;
    public int s1 = 0, s2 = 0;
    Rigidbody2D Rd;

    // Start is called before the first frame update
    void Start()
    {
        Gra = 0.5f;
        Rd = gameObject.GetComponent<Rigidbody2D>();
        InvokeRepeating("Stonespawn1", 2f, Ti);
        InvokeRepeating("Stonespawn2", 2f, Ti);
        InvokeRepeating("StoneGravity", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void Stonespawn1()
    {
        s1 = Random.Range(0,4);
        if (s1 == 1)
        {
            Instantiate(Stone1, new Vector3(-2, 6, 0), Quaternion.identity);
            
        }
        if (s1 == 2)
        {
            Instantiate(Stone1, new Vector3(0, 6, 0), Quaternion.identity);

        }
        if (s1 == 3)
        {
            Instantiate(Stone1, new Vector3(2, 6, 0), Quaternion.identity);

        }
        Ti -= 0.01f;
        Gra += 0.001f;
    }
    public void Stonespawn2()
    {
        s2 = Random.Range(0, 4);
        if (s2 == 1)
        {
            Instantiate(Stone2, new Vector3(-2, 6, 0), Quaternion.identity);

        }
        if (s2 == 2)
        {
            Instantiate(Stone2, new Vector3(0, 6, 0), Quaternion.identity);

        }
        if (s2 == 3)
        {
            Instantiate(Stone2, new Vector3(2, 6, 0), Quaternion.identity);

        }
        Ti -= 0.01f;
        Gra += 0.001f;
    }
}
