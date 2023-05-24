using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Entity
{
    public AudioManager audioManager;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb.velocity = new Vector2(rb.velocity.x, 20);
            audioManager.Play("PlayerBoost");
        }
    }
}
