using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public KeyCode GameClose;
    public GameObject Minigame;
    public GameObject Game3D;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(GameClose))
        {
            Close();
        }
    }

    void Close()
    {
        Minigame.SetActive(false);
        Game3D.SetActive(true);
        Time.timeScale = 1.0f;
        this.gameObject.SetActive(false);
   
    }
}