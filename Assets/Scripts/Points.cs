using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Points : MonoBehaviour
{
    public int points;
    public float pointMultiplier;
    public bool autoClick;
    
    public event Action<int> OnPointsChanged = delegate {  };
    
    public void Click()
    {
        points += (int)(1 * pointMultiplier);
        OnPointsChanged(points);
    }

    private void Update()
    {
        if (autoClick)
        {
            Click();
        }
    }
}
