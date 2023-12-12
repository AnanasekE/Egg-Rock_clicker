using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    private bool _canClick;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && GameManager.Instance.points.autoClick == false && _canClick)
        {
            GameManager.Instance.points.Click();
        }
    }
    
    public void SetCanClick(bool canClick)
    {
        _canClick = canClick;
    }
}
