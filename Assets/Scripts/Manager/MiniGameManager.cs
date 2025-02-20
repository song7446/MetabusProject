using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using static UnityEngine.InputSystem.XR.TrackedPoseDriver;

public class MiniGameManager : MonoBehaviour
{
    // 미니게임 매니저 싱글톤 
    public static MiniGameManager Instance;

    public bool isGameOn = false;

    private UIManager uiManager;
    public ObstacleManager obstacleManager;

    private float time = 0f;

    [SerializeField] private GameObject sampleObstacle;

    // 게임 시작 함수 
    public void StartGame()
    {
        // 시간 초기화 
        time = 0f;
        uiManager.SetPlayGame();
        // 게임 시작 시 예시 장애물 비활성화 
        sampleObstacle.SetActive(false);
        
        // 장애물 생성 코루틴 
        StartCoroutine(CreateObstacles());
    }

    // 게임 종료 함수 
    public void StopGame()
    {
        // 최고 점수 업데이트 
        if (PlayerPrefs.GetFloat("BestTime") < time)
        {
            PlayerPrefs.SetFloat("BestTime", time);
        }
        uiManager.ChangeBestTime(PlayerPrefs.GetFloat("BestTime"));
        uiManager.SetStopGame(time);
        obstacleManager.DestroyObstacles();

        // 장애물 생성 코루틴 종료 
        StopAllCoroutines();
    }

    private void Awake()
    {
        Instance = this;

        // UI 매니저 불러오기 
        uiManager = FindObjectOfType<UIManager>();
        // 장애물 매니저 불러오기 
        obstacleManager = GetComponentInChildren<ObstacleManager>();

        // 저장된 최고점수가 없다면 0으로 저장 
        if (!PlayerPrefs.HasKey("BestTime"))
            PlayerPrefs.SetFloat("BestTime", 0f);
    }

    private void Update()
    {
        // 게임 중일 때만 시간 측정 
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
