using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneName : MonoBehaviour
{
    //use the one with UGUI since on canvas
    TextMeshProUGUI sceneNameLabel;
    void Start()
    {
       sceneNameLabel = GetComponent<TextMeshProUGUI>();
        //gets hold of current scene and puts the name into the text
        sceneNameLabel.text = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        
    }
}
