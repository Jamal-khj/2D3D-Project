using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losegame : MonoBehaviour
{
    public GameObject losemessage;
    void Start()
    {
        losemessage.SetActive(false);
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Time.timeScale = 0.0f;
            losemessage.SetActive(true);
        }
    }
}
