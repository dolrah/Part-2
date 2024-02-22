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

    private void OnMouseDown()
    {
        Controller.setselectedplayer(this);
    }

}
