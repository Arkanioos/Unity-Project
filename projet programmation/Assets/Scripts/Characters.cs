using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Characters : Entity
{
    [SerializeField] protected Transform groundCheck;
    [SerializeField] protected LayerMask groundLayer;

    protected float horizontal;
    protected float speed = 6f;
    protected float jumpingPower = 16f;
    protected bool isFacingRight = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    abstract protected void Flip();

    abstract protected void Move();
}
