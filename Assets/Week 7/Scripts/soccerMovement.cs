using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccerMovement : MonoBehaviour
{
    SpriteRenderer playerselected;
    Rigidbody2D rb;

    public float speed = 49f;
    bool clickingOnSelf;

    private void Start()
    {
        playerselected = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        seleceted(false); 
    }


    //if player is selected highlights them
    public void seleceted(bool clickingOnSelf)
    {
        if (clickingOnSelf == true)
        {
          
            playerselected.color = Color.magenta;
        }
        else { playerselected.color = Color.white; }
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }

    private void OnMouseDown()
    {
        Controller.setselectedplayer(this);
    }

}
