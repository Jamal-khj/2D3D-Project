using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform CamerPosition;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = CamerPosition.position;
    }
}