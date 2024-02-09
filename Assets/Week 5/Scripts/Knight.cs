using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Vector2 movement;
    Vector2 destination;
    public float speed = 3f;
    Rigidbody2D rb;

    public float health;
    public float maxHealth = 5f;

    bool isDead = false;    

    bool clickingOnSelf = false;

    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        animator = GetComponent<Animator>();
        health = maxHealth;
    }

    private void FixedUpdate()
    {
        //deals with the movement
        movement = destination - (Vector2)transform.position;

        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position+movement.normalized*speed*Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !clickingOnSelf )
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        animator.SetFloat("Movment", movement.magnitude);


    }

    public void Takedamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
        if (health == 0)
        {
            isDead = true;
            animator.SetTrigger("death");
        }
        else
        {
            isDead =false;
            animator.SetTrigger("TakeDamage");
        }
    }

    private void OnMouseDown()
    {
        if (isDead) return;
        clickingOnSelf = true;
        // makes it so the entire system know you took damage
        //SendMessage("TakeDamage", 1);
    }
    private void OnMouseUp()
    {
        clickingOnSelf = false;
    }
}
