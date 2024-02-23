using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lets you do stuff with the scenes
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int delay = 0;
    public void NextScene()
    {
        //figures out what scene the player is on
        int currentscene = SceneManager.GetActiveScene().buildIndex;

        //figures out what the next scene is
        // if there are no more 'next scenes' it loops back to the first one
        int nextscene = (currentscene + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextscene);
    }

    public void Planet(int value)
    {
        delay = 0;
        while(delay != 400)
        {
            delay++;
        }
        SceneManager.LoadScene(value);
    }

}
