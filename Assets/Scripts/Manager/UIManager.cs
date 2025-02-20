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
    // 싱글톤으로 생성 
    public static UIManager Instance;

    // 포탈 상호작용 설명 텍스트
    [SerializeField] private GameObject potalTextOBj;

    // 기본 UI
    HomeUI homeUI;
    // 게임 중 UI
    GameUI gameUI;
    // 게임 끝났을 때 UI
    GameOverUI gameOverUI;

    // UI 현재 상태 
    private UIState currneState;

    public bool isGameOn = false;

    private void Awake()
    {
        Instance = this;

        // 미니 게임 중일 때만 사용하는 UI 생성
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

    // UI 상태변경 
    private void ChangeState(UIState state)
    {
        currneState = state;

        homeUI.SetActive(state);
        gameUI.SetActive(state);
        gameOverUI.SetActive(state) ;
    }

    // 상호작용 설명 텍스트 활성화 비활성화 함수  
    public void InterActionTextOnOff(bool isInterAction)
    {
        potalTextOBj.SetActive(isInterAction);
    }

    // 미니 게임 시작 함수 
    public void SetPlayGame()
    {
        ChangeState(UIState.GameUI);
        isGameOn = true;
    }

    // 미니 게임 종료 
    public void SetStopGame(float time)
    {
        isGameOn = false;
        gameOverUI.SetCurTime(time);  
        ChangeState(UIState.GameOverUI);
    }

    // 미니 게임 중 사용하는 시간 업데이트 함수 
    public void ChangeTime(float time)
    {       
        gameUI.UpdateTime(time);
    }

    // 최고 점수 변경 함수 
    public void ChangeBestTime(float time)
    {
        gameOverUI.SetBestTime(time);
    }
}
