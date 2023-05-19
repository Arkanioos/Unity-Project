using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : Characters
{


    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    override protected void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }

}
