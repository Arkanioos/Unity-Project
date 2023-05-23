using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : Entity
{
    protected float horizontal;
    protected float speed = 6f;
    protected float jumpingPower = 16f;
    protected bool isFacingRight = true;
    public Player player;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override protected void Move()
    { 
    }

    override protected void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
