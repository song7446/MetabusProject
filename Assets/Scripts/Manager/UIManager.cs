using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum UIState
{
    HomeUI,
    GameUI,
    GameOverUI,
}


public class UIManager : MonoBehaviour
{
    // �̱������� ���� 
    public static UIManager Instance;

    // ��Ż ��ȣ�ۿ� ���� �ؽ�Ʈ
    [SerializeField] private GameObject potalTextOBj;

    // �⺻ UI
    HomeUI homeUI;
    // ���� �� UI
    GameUI gameUI;
    // ���� ������ �� UI
    GameOverUI gameOverUI;

    // UI ���� ���� 
    private UIState currneState;

    public bool isGameOn = false;

    private void Awake()
    {
        Instance = this;

        // �̴� ���� ���� ���� ����ϴ� UI ����
        if (SceneManager.GetActiveScene().name == "MiniGameScene")
        {
            homeUI = GetComponentInChildren<HomeUI>(true);
            homeUI.Init(this);

            gameUI = GetComponentInChildren<GameUI>(true);
            gameUI.Init(this);

            gameOverUI = GetComponentInChildren<GameOverUI>(true);
            gameOverUI.Init(this);

            ChangeState(UIState.HomeUI);
        }
    }

    // UI ���º��� 
    private void ChangeState(UIState state)
    {
        currneState = state;

        homeUI.SetActive(state);
        gameUI.SetActive(state);
        gameOverUI.SetActive(state) ;
    }

    // ��ȣ�ۿ� ���� �ؽ�Ʈ Ȱ��ȭ ��Ȱ��ȭ �Լ�  
    public void InterActionTextOnOff(bool isInterAction)
    {
        potalTextOBj.SetActive(isInterAction);
    }

    // �̴� ���� ���� �Լ� 
    public void SetPlayGame()
    {
        ChangeState(UIState.GameUI);
        isGameOn = true;
    }

    // �̴� ���� ���� 
    public void SetStopGame(float time)
    {
        isGameOn = false;
        gameOverUI.SetCurTime(time);  
        ChangeState(UIState.GameOverUI);
    }

    // �̴� ���� �� ����ϴ� �ð� ������Ʈ �Լ� 
    public void ChangeTime(float time)
    {       
        gameUI.UpdateTime(time);
    }

    // �ְ� ���� ���� �Լ� 
    public void ChangeBestTime(float time)
    {
        gameOverUI.SetBestTime(time);
    }
}
