using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessMiniGame : MonoBehaviour
{
    public GameObject MiniGame;

    // Start is called before the first frame update
    void Start()
    {
        MiniGame.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MiniGame.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MiniGame.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}