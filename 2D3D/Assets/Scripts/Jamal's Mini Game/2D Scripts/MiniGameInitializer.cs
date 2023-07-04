using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameInitializer : MonoBehaviour
{
    public GameObject[] objectsToEnable;
    public GameObject[] objectsToDisable;
    private void OnEnable()
    {
        for (int i = 0; i < objectsToEnable.Length; i++) 
        {
            objectsToEnable[i].SetActive(true);
        }
        for (int i = 0; i < objectsToDisable.Length; i++)
        {
            objectsToDisable[i].SetActive(false);
        }
    }

}
