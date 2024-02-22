using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
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
}
