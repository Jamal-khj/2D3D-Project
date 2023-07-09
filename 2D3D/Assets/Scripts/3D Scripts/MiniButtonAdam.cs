using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniButtonAdam : MonoBehaviour
{
    public void LoadAdamGame()
    {
        SceneManager.LoadScene("Adam");
        Time.timeScale = 1.0f;
    }
}