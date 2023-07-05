using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniButtonKio : MonoBehaviour
{
    public void LoadKioGame()
    {
        SceneManager.LoadScene("Kio");
    }
}