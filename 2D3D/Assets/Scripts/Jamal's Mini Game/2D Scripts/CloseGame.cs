using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseGame : MonoBehaviour
{
    public KeyCode GameClose;
    
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
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main Game");
    }
}