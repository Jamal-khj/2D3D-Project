using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 8f;
    public float Jump;
    private float horizontal;
    private float jumpingpower;
    private bool isfacingright = true;

    private bool doublejump;

    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundlayer;
    void Start()
    {
      
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

       /* if(IsGrounded() && !Input.GetButton("Jump"))
        {
            doublejump= false;
        }

        if (Input.GetButtonDown("Jump"))
        { 
            if (IsGrounded() || doublejump)
            {
            
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpingpower);

                doublejump = !doublejump;
            }
        }
                  
        
        if(Input.GetButtonUp("Jump") && rb2d.velocity.y > 0f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
        }*/
       
        flip();
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(horizontal * speed,rb2d.velocity.y);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundlayer);
    }
    private void flip()
    {
        if(isfacingright && horizontal < 0f || !isfacingright && horizontal >0f)
        {
            isfacingright = !isfacingright;
            Vector3 localScale = transform.localScale;
            localScale.x *= 1f;
            transform.localScale = localScale;
        }
    }
}
