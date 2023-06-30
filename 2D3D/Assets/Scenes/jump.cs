using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
   private Rigidbody2D rb2d;
    public float Jump;
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, Jump));
        }
    }
}
