using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShootingCountDown : MonoBehaviour
{
    // Seetting the timer objects
    private float CurrentTime = 0.0f;
    public float StartingTime;
    public TextMeshProUGUI CountDownText;

    // Timer ends objects
    public GameObject WinScreen;
    public static bool isWin;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = StartingTime;
        WinScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        CountDownText.text = "" + (int)CurrentTime;

        if (CurrentTime < 0.0f)
        {
            Win();
        }
    }

    public void Win()
    {
        WinScreen.SetActive(true);
        Time.timeScale = 0.0f;
        isWin = true;
    }
}
