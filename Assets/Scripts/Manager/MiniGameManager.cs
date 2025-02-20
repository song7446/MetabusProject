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
    public ObstacleManager obstacleManager;

    private float time = 0f;

    [SerializeField] private GameObject sampleObstacle;


    public void StartGame()
    {
        time = 0f;
        uiManager.SetPlayGame();
        sampleObstacle.SetActive(false);   
        StartCoroutine(CreateObstacles());
    }

    public void StopGame()
    {
        if (PlayerPrefs.GetFloat("BestTime") < time)
        {
            PlayerPrefs.SetFloat("BestTime", time);
            uiManager.ChangeBestTime(time);
        }
        uiManager.SetStopGame(time);
        obstacleManager.DestroyObstacles();
        StopAllCoroutines();
    }

    private void Awake()
    {
        Instance = this;

        uiManager = FindObjectOfType<UIManager>();
        obstacleManager = GetComponentInChildren<ObstacleManager>();
        PlayerPrefs.SetFloat("BestTime", time);
    }

    private void Update()
    {
        if (uiManager.isGameOn)
        {
            time += Time.deltaTime;
            uiManager.ChangeTime(time);
        }
    }

    IEnumerator CreateObstacles()
    {
        while (true)
        {
            obstacleManager.CreateObstacle();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
