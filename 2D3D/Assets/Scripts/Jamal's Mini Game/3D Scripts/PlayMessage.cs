using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMessage : MonoBehaviour
{
    public GameObject MessagePlay;
    public GameObject Interact;
    
    // Start is called before the first frame update
    void Start()
    {
        MessagePlay.SetActive(false);
        Interact.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            MessagePlay.SetActive(true);
            Interact.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MessagePlay.SetActive(false);
            Interact.SetActive(false);
        }
    }
}