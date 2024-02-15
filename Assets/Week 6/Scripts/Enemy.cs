using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    bool clickingOnEnemy;
    public float maxHealth = 3;
    public float health;
    public float damage = 1f;

    void Start()
    {
        health = maxHealth;
   
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1) && !clickingOnEnemy)
        {
            health = health -1;
        }
    }


     private void OnMouseDown()
    {
        clickingOnEnemy = true;
        SendMessage("TakeDamage", 2);

        
    }

    public void TakeDamage()
    {
        health -= 1;
        health = Mathf.Clamp(health, 0, maxHealth);
        if (health == 0)
        {
            //gets you what the current scene is
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //gets the next scene
            //% if the number that will be loaded from the code before that is bigger than whats after, reset it to zero
            int nextSceneIndext = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(nextSceneIndext);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("TakeDamage", 2, SendMessageOptions.DontRequireReceiver);
    }

}
