using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using static UnityEngine.InputSystem.XR.TrackedPoseDriver;

public class MiniGameManager : MonoBehaviour
{
    public static MiniGameManager Instance;

    public bool isGameOn = false;

    private UIManager uiManager;
    private ObstacleManager obstacleManager;

    private float time = 0f;

    [SerializeField] private GameObject sampleObstacle;

    public void StartGame()
    {
        time = 0f;
        uiManager.SetPlayGame();
        sampleObstacle.SetActive(false);
        obstacleManager.CreateObstacle();
    }

    public void StopGame()
    {
        uiManager.SetStopGame();
    }

    private void Awake()
    {
        Instance = this;

        uiManager = FindObjectOfType<UIManager>();
        obstacleManager = GetComponentInChildren<ObstacleManager>();
    }

    private void Update()
    {
        if (uiManager.isGameOn)
        {
            time += Time.deltaTime;
            uiManager.ChangeTime(time);
        }

    }
}
