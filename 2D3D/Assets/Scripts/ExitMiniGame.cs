using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMiniGame : MonoBehaviour
{
    public void loadmaingame()
    {
        SceneManager.LoadScene("Main Game");
        Time.timeScale= 1.0f;
    }
   
}
