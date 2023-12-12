using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Points points;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("GameManager already exists!");
            DestroyImmediate(this);
        }

        SetupOnAwake();
    }

    private void SetupOnAwake() {}
    
    
}