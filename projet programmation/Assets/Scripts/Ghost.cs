using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Characters
{
    public GameObject pointA;
    public GameObject pointB;

    private Transform currentPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentPoint = pointB.transform;
    }

    private void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }
}
