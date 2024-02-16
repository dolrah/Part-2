using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenResolusion : MonoBehaviour
{
      Screen screen;

    //this is so you can set the info for the screen res for each button in the thing
    public int width;
    public int height;
    public bool fullscreen;
    void Start()
    {
        screen = GetComponent<Screen>();
    }

   public void ScreenRes()
    {
       Screen.SetResolution(width, height, fullscreen);    
    }

}
