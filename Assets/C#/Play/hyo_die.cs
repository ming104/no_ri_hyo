using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hyo_die : MonoBehaviour
{
    public int life;
    public SpriteRenderer hyo;
    public AudioSource HPM;
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public bool nodie;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        hyo = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (nodie == false)
        {
            HPM.Play();
            life--;
            nodie = true;
            hyo.color = new Color(1, 1, 1, 0.5f);
            Invoke("Colora", 1);
            if (life == 2)
            {
                Life3.SetActive(false);
                if (Vibration.VibrationOn == true)
                {
                    Handheld.Vibrate();
                }
            }
            if (life == 1)
            {
                Life2.SetActive(false);
                if (Vibration.VibrationOn == true)
                {
                    Handheld.Vibrate();
                }
            }
        }
    }
    void Colora()
    {
        hyo.color = new Color(1, 1, 1, 1f);
        
        nodie = false;
    }
}
