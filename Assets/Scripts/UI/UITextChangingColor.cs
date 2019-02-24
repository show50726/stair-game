﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UITextChangingColor : MonoBehaviour
{

    public Text text;
    [Range(0.002f, 0.999f)]
    [Tooltip("The hue value in program verify from 0 to 1. if changing value too large, this will make color looks like the same.")]
    public float changingSpeed = 0.005f;

    private float h, s, v;

    private void Start()
    {
        if (text == null)
        {
            text = GetComponent<Text>();
            if (text == null)
            {
                Debug.LogWarning(GetType().Name + " warning: you didn't assign text, thus this script won't work.");
                enabled = false;
            }
        }
    }

    private void Update()
    {
        Color.RGBToHSV(text.color, out h, out s, out v);
        h += changingSpeed*Time.deltaTime;

        while (h > 1)
        {
            h--;
        }

        //Debug.Log("hsv is now " + h + " " + s + " " + v);

        //Debug.Log("Translate to RGB: " + Color.HSVToRGB(h, s, v));

        text.color = Color.HSVToRGB(h, s, v);

        Color.RGBToHSV(text.color, out h, out s, out v);

        //Debug.Log("The new color is " + h + " " + s + " " + v);


        //text.color = Color.white;

    }


}
