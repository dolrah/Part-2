using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //lets you access things on a diffrent gameobject
    public Slider chargeslider;
    float chargeValue;
    public float chargeValueMax=1;
    Vector2 direction;

    //access another script
    public static soccerMovement selectedPlayer { get; private set; }

    //static makes it so all scripts can access it if they use the name of the script.function
    //controller. setselectedplayer
    public static void setselectedplayer (soccerMovement player)
    {
        //if the player is not selected this tells the player they are not selected
        if (selectedPlayer != null)
        {
            selectedPlayer.seleceted(false);
        }
        selectedPlayer = player;
        selectedPlayer.seleceted(true);
    }

    //fixed updated is used to apply force to rigid bodies
    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            selectedPlayer.Move(direction);

            //after the above bit is done (moves the player) resets everything back to zero
            direction = Vector2.zero;
            chargeValue = 0;
            chargeslider.value = chargeValue;
        }
    }

    private void Update()
    {
        //checks if there is a player selected (if true the return part will skip the rest of the function)
        if (selectedPlayer == null) return;

        //when the spacebar is first pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chargeValue = 0;
            direction = Vector2.zero;
        }
        //all the keys the space bar is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            chargeValue += Time.deltaTime;
            //ensure that the charge value cant go over the max by clamping it
            chargeValue = Mathf.Clamp(chargeValue, 0, chargeValueMax);
            chargeslider.value = chargeValue;
        }
        //when it is released
        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - selectedPlayer.transform.position).normalized * chargeValue;
        }
    }
}
