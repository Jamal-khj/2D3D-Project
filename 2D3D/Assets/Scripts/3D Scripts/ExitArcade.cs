using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitArcade : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Main Menu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}