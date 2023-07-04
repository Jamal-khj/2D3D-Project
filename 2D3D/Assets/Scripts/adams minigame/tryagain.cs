using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryagain : MonoBehaviour
{
    public void loadadamgame()
    {
        SceneManager.LoadScene("Adam");
        Time.timeScale = 1.0f;
    }

   
}
