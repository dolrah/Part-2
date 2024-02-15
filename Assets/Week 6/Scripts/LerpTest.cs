using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{

    public AnimationCurve animationcurve;
    public Transform startPosition;
    public Transform endPosition;
    public Color startColor;
    public Color endColor;

    public SpriteRenderer sr;


    public float lerpTimer;

    void Update()
    {
        float interpolation = animationcurve.Evaluate(lerpTimer);
        //moves the square from first vector to second vector
        transform.position = Vector3.Lerp(startPosition.position,endPosition.position,interpolation);

        lerpTimer+=Time.deltaTime;

        sr.color = Color.Lerp(startColor, endColor,interpolation);
    }
}
