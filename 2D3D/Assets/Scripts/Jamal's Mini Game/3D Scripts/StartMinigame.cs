using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{
    public KeyCode Interact;
    public GameObject Minigame;
    public GameObject Game3D;
    
    // Start is called before the first frame update
    void Start()
    {
        Minigame.SetActive(false);
        Game3D.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Interact))
        {
            PlayMinigame();
        }
    }

    void PlayMinigame()
    {
        Minigame.SetActive(true);
        Game3D.SetActive(false);
    }
}