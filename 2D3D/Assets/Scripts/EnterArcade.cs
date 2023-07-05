using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterArcade : MonoBehaviour
{
    public void LoadArcade()
    {
        SceneManager.LoadScene("Main Game");
    }
}