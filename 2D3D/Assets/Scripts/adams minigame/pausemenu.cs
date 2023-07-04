using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public GameObject Pausemenu;
    public static bool ispaused;
    public KeyCode pauseKey;
   
    public void playgame()
    {
        SceneManager.LoadScene("MainMenu");

        
    }
    void Start()
    {
        Pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pauseKey))
        {
            //Pausemenu.SetActive(true);
            if (ispaused)
            {
                Resumegame();
            }
            else
            {
                pausegame();
            }
        }
    }
    public void pausegame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }
    public void Resumegame()
    {
        Pausemenu.SetActive(false) ;
        Time.timeScale = 1f;
        ispaused = false;
    }
}
