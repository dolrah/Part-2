using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMove : MonoBehaviour
{
    Vector2 destination;
    Vector2 doctormovement;
    public float speed = 3f;
    public  Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        doctormovement = destination - (Vector2)transform.position;

        if (doctormovement.magnitude < 0.1)
        {
            doctormovement = Vector2.zero;
        }
        rb.MovePosition(rb.position + doctormovement.normalized * speed * Time.deltaTime);
        
    }

    private void Update()
    {
        //checks where youre clicking
        if (Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

    }


}
