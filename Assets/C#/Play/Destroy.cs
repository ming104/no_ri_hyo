using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = Stone_Ge.Gra;
        Destroy(gameObject, 3.5f);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
