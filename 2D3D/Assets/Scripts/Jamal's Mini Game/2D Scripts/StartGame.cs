using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public KeyCode GameStart;
    public GameObject TheGame;
    public GameObject StartMenu;

    // Start is called before the first frame update
    void Start()
    {
        TheGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(GameStart))
        {
            StartTheGame();
        }
    }

    void StartTheGame()
    {
        TheGame.SetActive(true);
        StartMenu.SetActive(false);
    }
}
