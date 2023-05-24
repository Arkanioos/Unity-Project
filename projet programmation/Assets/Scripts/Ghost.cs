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

        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void Update()
    {
<<<<<<< HEAD
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed/2, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed/2, 0);
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            Flip();
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            Flip();
            currentPoint = pointB.transform;
        }
=======
        Move();
>>>>>>> 6933bc136e0c7ead74e0b82dd650ab5f5201ab24
    }

    private void FixedUpdate()
    {
        Move();
    }

    override protected void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
<<<<<<< HEAD
=======

    override protected void Move()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed / 2, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed / 2, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            Flip();
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            Flip();
            currentPoint = pointB.transform;
        }
    }
>>>>>>> 6933bc136e0c7ead74e0b82dd650ab5f5201ab24
}
