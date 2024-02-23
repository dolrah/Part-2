using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class SwitchingPlanet : MonoBehaviour
{
    Animator animator;
    int planet;
    private void Start()
    {
        animator = GetComponent<Animator>();
      
    }


    public void LookingPlanet(int num)
    {
        //this should change planets(the animation on the side) when a new one is selected
        switch (num)
        {
            case 0: animator.SetInteger("Planet",1); break;
            case 1: animator.SetInteger("Planet",2); break;
            case 2: animator.SetInteger("Planet",3); break;
            case 3: animator.SetInteger("Planet",4); break;
            case 4: animator.SetInteger("Planet",5); break;
            case 5: animator.SetInteger("Planet",6); break;
            case 6: animator.SetInteger("Planet",7); break;
            case 7: animator.SetInteger("Planet",8); break;
            case 8: animator.SetInteger("Planet",9); break;
            case 9: animator.SetInteger("Planet",10); break;
            case 10:animator.SetInteger("Planet",11); break;
            case 11:animator.SetInteger("Planet",12); break;
            case 12:animator.SetInteger("Planet",13); break;

           SendMessage("Planet", num + 2);
        }
        planet = num;

    }


    public void Update()
    {
        LookingPlanet(planet);
    }
}
