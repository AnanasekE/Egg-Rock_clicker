using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int points;
    public float pointMultiplier;
    
    public bool click;

    public void Click()
    {
        points += (int)(1 * pointMultiplier);
    }

    private void Update()
    {
        if (click)
        {
            Click();
        }
    }
}
