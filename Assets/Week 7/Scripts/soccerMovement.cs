using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccerMovement : MonoBehaviour
{
    SpriteRenderer playerselected;
    bool clickingOnSelf;

    private void Start()
    {
        playerselected = GetComponent<SpriteRenderer>();
        playerselected.color = Color.white;
    }

    private void Update()
    {
        seleceted(clickingOnSelf);
    }

    public void seleceted(bool clickingOnSelf)
    {
        if (clickingOnSelf == true)
        {
            print("clicking on self");
            playerselected.color = Color.cyan;
        }
        else { playerselected.color = Color.white; }
    }

    private void OnMouseDown()
    {
        print("mousedown");
        clickingOnSelf = true;
    }

    private void OnMouseUp()
    {
        print("mouseup");
        clickingOnSelf = false;
    }
}
