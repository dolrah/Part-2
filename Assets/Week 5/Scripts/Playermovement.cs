using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Vector3 mouseClick;
    public Vector3 currentPos;
    public Camera Maincamera;

   public GameObject player;

    bool north;
    bool south;
    bool east;
    bool west;
   
    void Start()
    {
        //sets the starting pos for the caracter
        currentPos.x = 0;
        currentPos.y = 0;
        
    }


    void Update()
    {
        //if (north) { player.transform.position = currentPos; }
        mouseClick = Input.mousePosition;
        Debug.Log(mouseClick);
    }

    private void OnMouseDown()
    {
        //gets and stores the cords where the mouse was clicked
        Vector3 mousePos = Maincamera.ScreenToWorldPoint(Input.mousePosition);
        mouseClick = Input.mousePosition;
/*
        if (currentPos.x < mouseClick.x) { east = true; }
        if (currentPos.y < mouseClick.y) { south = true; }
        if (currentPos.x > mouseClick.x) { west = true; }
        if (currentPos.y > mouseClick.y) { north = true; }

     */   
        
    }
}
