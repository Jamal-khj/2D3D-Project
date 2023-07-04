using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingame : MonoBehaviour
{
    public GameObject winmessage;
    void Start()
    {
        winmessage.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            Time.timeScale = 0.0f;
            winmessage.SetActive(true);
        }
    }
}
