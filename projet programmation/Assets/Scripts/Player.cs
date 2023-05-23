using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : Characters
{

    protected int maxHealth;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        maxHealth = 3;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        animator = GetComponent<Animator>();

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

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if(currentHealth==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    override protected void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Ennemy"|| collision.tag=="Trap")
        {
            TakeDamage(1);
        }

        if(collision.tag=="End")
        {
            SceneManager.LoadLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

}
