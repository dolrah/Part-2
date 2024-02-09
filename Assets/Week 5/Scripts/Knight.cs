using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Vector2 movement;
    Vector2 destination;
    public float speed = 3f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position+movement.normalized*speed*Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


    }
}
