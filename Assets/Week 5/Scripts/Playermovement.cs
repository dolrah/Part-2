using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Vector2 mouseClick;
    public Vector2 currentPos;
    public float speed;



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
        

        
        Debug.Log(mouseClick);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouseclicked");
            //gets and stores the cords where the mouse was clicked
            Vector2 mousePos = Maincamera.ScreenToWorldPoint(Input.mousePosition);
            mouseClick = mousePos;
            
                    if (currentPos.x < mouseClick.x) { east = true; }
            else { east = false; }
                    if (currentPos.y < mouseClick.y) { south = true; }
            else { south = false; }
                    if (currentPos.x > mouseClick.x) { west = true; }
            else { west = false; }
                    if (currentPos.y > mouseClick.y) { north = true; }
            else { north = false; }

             
        }


        if (north == true)
        {
            if (Vector2.Distance(currentPos, mouseClick) > 1)
            {
                currentPos.y = currentPos.y - speed;
                currentPos.y = transform.position.y;
                
            }
 
          
        }

        if (south == true)
        {
            if (Vector2.Distance(currentPos, mouseClick) > 1)
            {
                currentPos.y = currentPos.y + speed;
               currentPos.y = transform.position.y;
                
            }

        }

        if (east == true)
        {
            if (Vector2.Distance(currentPos, mouseClick) > 1)
            {
                currentPos.x = currentPos.x + speed;
                currentPos.x = transform.position.x;
                

            }
       
        }

        if (west == true)
        {
            if (Vector2.Distance(currentPos, mouseClick) > 1)
            {
                currentPos.x = currentPos.x - speed;
                currentPos.x = transform.position.x;
               

            }
          
        }
    }


}
