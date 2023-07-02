using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FloorHealth : MonoBehaviour
{
    // Setting Floor Health Objects
    public float MaxHealth;
    public float CurrentHealth;
    public TextMeshProUGUI Health;

    // Setting Losing screen
    public GameObject GameOverMessage;
    public static bool isGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        GameOverMessage.SetActive(false);
    }

    void Update()
    {
        Health.text = "Floor Health: " + (int)CurrentHealth + "/" + (int)MaxHealth;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            CurrentHealth -= 1.0f;

            if(CurrentHealth <= 0.0f)
            {
                GameOverMessage.SetActive(true);
                Time.timeScale = 0.0f;
                isGameOver = true;
            }
        }
    }
}