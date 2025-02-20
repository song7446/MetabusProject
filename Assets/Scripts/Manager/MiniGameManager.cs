using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using static UnityEngine.InputSystem.XR.TrackedPoseDriver;

public class MiniGameManager : MonoBehaviour
{
    // �̴ϰ��� �Ŵ��� �̱��� 
    public static MiniGameManager Instance;

    public bool isGameOn = false;

    private UIManager uiManager;
    public ObstacleManager obstacleManager;

    private float time = 0f;

    [SerializeField] private GameObject sampleObstacle;

    // ���� ���� �Լ� 
    public void StartGame()
    {
        // �ð� �ʱ�ȭ 
        time = 0f;
        uiManager.SetPlayGame();
        // ���� ���� �� ���� ��ֹ� ��Ȱ��ȭ 
        sampleObstacle.SetActive(false);
        
        // ��ֹ� ���� �ڷ�ƾ 
        StartCoroutine(CreateObstacles());
    }

    // ���� ���� �Լ� 
    public void StopGame()
    {
        // �ְ� ���� ������Ʈ 
        if (PlayerPrefs.GetFloat("BestTime") < time)
        {
            PlayerPrefs.SetFloat("BestTime", time);
        }
        uiManager.ChangeBestTime(PlayerPrefs.GetFloat("BestTime"));
        uiManager.SetStopGame(time);
        obstacleManager.DestroyObstacles();

        // ��ֹ� ���� �ڷ�ƾ ���� 
        StopAllCoroutines();
    }

    private void Awake()
    {
        Instance = this;

        // UI �Ŵ��� �ҷ����� 
        uiManager = FindObjectOfType<UIManager>();
        // ��ֹ� �Ŵ��� �ҷ����� 
        obstacleManager = GetComponentInChildren<ObstacleManager>();

        // ����� �ְ������� ���ٸ� 0���� ���� 
        if (!PlayerPrefs.HasKey("BestTime"))
            PlayerPrefs.SetFloat("BestTime", 0f);
    }

    private void Update()
    {
        // ���� ���� ���� �ð� ���� 
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
