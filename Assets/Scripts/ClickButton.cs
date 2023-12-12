using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.points.setAutoclicker(!GameManager.Instance.points.autoClick);
        }
    }
}
