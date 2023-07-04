using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class movement : MonoBehaviour
{
    public float speed = 8f;
    public float Jump;
    private float horizontal;
    private float jumpingpower;
    private bool isfacingright = true;
    private bool doublejump;
    private bool iswallsliding = true;
    private float wallslidingspeed = 2f;

    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] private Transform wallcheck;
    [SerializeField] private LayerMask walllayer;
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(IsGrounded() && !Input.GetButton("Jump"))
        {
            doublejump= false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump runniong");
            if (IsGrounded() || doublejump)
            {
                Debug.Log("Jump runniong !!!!!!");
                //Vector2 velo = new Vector2(rb2d.velocity.x, rb2d.velocity.y);
                rb2d.AddForce(new Vector2(rb2d.velocity.x, Jump));

                doublejump = !doublejump;
            }

        }


         if(Input.GetButtonUp("Jump") && rb2d.velocity.y > 0f)
         {
             rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
         }

        WallSlide();
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

    private bool IsWalled()
    {
        return Physics2D.OverlapCircle(wallcheck.position, 0.2f,walllayer);     
    }

    private void WallSlide()
    {
        if (IsWalled() && !IsGrounded() && horizontal != 0f)
        {
            Debug.Log("Doing something");
            iswallsliding= true;
            rb2d.velocity = new Vector2(rb2d.velocity.x,Mathf.Clamp(rb2d.velocity.y - wallslidingspeed, float.MinValue ,float.MaxValue));
        }
        else
        {
            iswallsliding= false;
        }
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
