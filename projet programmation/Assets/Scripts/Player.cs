using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : Characters
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (!IsGrounded())
        {
            animator.SetBool("isJumping", true);
        }
        else if (IsGrounded())
        {
            animator.SetBool("isJumping", false);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    override protected void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }
}
