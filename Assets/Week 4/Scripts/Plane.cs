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

    Vector2 currentPosition;

    Rigidbody2D rb;

    public float speed = 1f;

    public AnimationCurve landing;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.SetPosition(0,transform.position);

        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        lineRenderer.SetPosition(0 , transform.position);
        if(points.Count > 0)
        {
            if (Vector2.Distance(currentPosition, points[0]) < newPositionThreshold)
            {
                points.RemoveAt(0);
                for(int i = 0; i< lineRenderer.positionCount -2; i++)
                {
                    lineRenderer.SetPosition(i,lineRenderer.GetPosition(i+1));
                }
                lineRenderer.positionCount--;
            }
        }
    }

    private void FixedUpdate()
    {
        currentPosition = transform.position;
        if (points.Count > 0)
        {
            Vector2 direction = points[0] - currentPosition;
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            rb.rotation = -angle;
        }
        rb.MovePosition(rb.position + (Vector2)transform.up * speed * Time.deltaTime);
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
