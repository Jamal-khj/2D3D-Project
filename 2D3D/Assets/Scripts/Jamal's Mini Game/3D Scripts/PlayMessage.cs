using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMessage : MonoBehaviour
{
    public GameObject MessagePlay;
    
    // Start is called before the first frame update
    void Start()
    {
        MessagePlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            MessagePlay.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MessagePlay.SetActive(false);
        }
    }
}