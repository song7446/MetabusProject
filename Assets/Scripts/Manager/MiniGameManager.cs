using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.XR.TrackedPoseDriver;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager Instance;

    public bool isGameOn = false;

    private UIManager uiManager;

    public void StartGame()
    {
        uiManager.SetPlayGame();        
    }

    private void Awake()
    {
        Instance = this;

        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        uiManager.ChangeTime();
    }
}
