using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{
    [SerializeField] private Transform puzzleField;
    [SerializeField] private GameObject puzzleBtn;

    private void Awake()
    {
        for(int i = 0; i < 8; i++)
        {
            GameObject puzzleButton = Instantiate(puzzleBtn);
            puzzleButton.name = "" + i;
            puzzleButton.transform.SetParent(puzzleField, false);
        }
    }
}
