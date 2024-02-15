using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lets you do stuff with the scenes
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
 public void loadNextScene()
    {
        //gets you what the current scene is
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
       //gets the next scene
       //% if the number that will be loaded from the code before that is bigger than whats after, reset it to zero
        int nextSceneIndext = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndext);
    }

}
