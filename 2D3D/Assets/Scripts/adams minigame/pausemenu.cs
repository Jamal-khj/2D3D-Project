using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public GameObject Pausemenu;
    public bool ispaused;
   
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
        if(Input.GetKeyDown(KeyCode.X))
        {
            Pausemenu.SetActive(true);
        }
    }
    public void pausegame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resumegame()
    {
        Pausemenu.SetActive(false) ;
        Time.timeScale = 1f;
    }
}
