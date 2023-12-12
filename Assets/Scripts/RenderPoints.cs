using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderPoints : MonoBehaviour
{
    // this is on a text object
    private TMPro.TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        GameManager.Instance.points.OnPointsChanged += RefreshPoints;
    }

    private void RefreshPoints(int points)
    {
        // make the points have commas
        
        _text.text = points.ToString("N0");
    }
}