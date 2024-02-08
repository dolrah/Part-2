using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Vector2 mouseClick;
    public Vector2 currentPos;

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
        if (north) { transform.position = currentPos; }
        
    }

    private void OnMouseDown()
    {
        //gets and stores the cords where the mouse was clicked
        Vector2 mousePos = transform.position;
        mouseClick = mousePos;

        if (currentPos.x < mouseClick.x) { east = true; }
        if (currentPos.y < mouseClick.y) { south = true; }
        if (currentPos.x > mouseClick.x) { west = true; }
        if (currentPos.y > mouseClick.y) { north = true; }

        
        
    }
}
