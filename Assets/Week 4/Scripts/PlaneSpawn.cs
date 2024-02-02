using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawn : MonoBehaviour
{
    public GameObject planePrefab;
    public float time;
    public float amount;

    public Vector3 location;
    public Quaternion rotate;



    void Update()
    {
        if (amount <= time)
        {

            time = 0f;
            amount = Random.Range(1, 5);
            location.x = Random.Range(-5, 5);
            location.y = Random.Range(-5, 5);
            rotate.z = Random.Range(0, 360);
          
            

            Instantiate(planePrefab, location, rotate);  
        }
        time = time + Time.deltaTime;
    }
}
