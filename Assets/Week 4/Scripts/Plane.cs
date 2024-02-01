using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    //makes a list to store data (the vector2 makes it store the data in x and y values
    public List<Vector2> points;

    Vector2 lastPosition;

    //access the line render for a trail
    LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.SetPosition(0,transform.position);
    }


    public float newPositionThreshold = 0.2f;

    //When the mouse is clicked
    private void OnMouseDown()
    {
        //inniates the list
        points = new List<Vector2>();

        //resets the list of points in linerender
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
    }

    //when the mouse is draged while chicked down
    private void OnMouseDrag()
    {
        //stores the newest mouses position
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //if the mouse has moved a reasable distince store the mouse value
        if (Vector2.Distance(newPosition, lastPosition) > newPositionThreshold)
        {
            points.Add(newPosition);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1 , newPosition);
            lastPosition = newPosition;
        }
    }

}
