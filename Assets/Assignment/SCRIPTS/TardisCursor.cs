using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lets you do stuff with the scenes
using UnityEngine.SceneManagement;

public class TardisCursor : MonoBehaviour
{
    //this is jsut to take you back to the chosing scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }
}
