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
    public static UIManager Instance;

    [SerializeField] private GameObject potalTextOBj;

    HomeUI homeUI;
    GameUI gameUI;
    GameOverUI gameOverUI;

    private UIState currneState;

    public bool isGameOn = false;
    private bool beforeGameOn = false;

    private void Awake()
    {
        Instance = this;

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

    private void ChangeState(UIState state)
    {
        currneState = state;

        homeUI.SetActive(state);
        gameUI.SetActive(state);
        gameOverUI.SetActive(state) ;
    }

    public void InterActionTextOnOff(bool isInterAction)
    {
        potalTextOBj.SetActive(isInterAction);
    }

    public void SetPlayGame()
    {
        ChangeState(UIState.GameUI);
        isGameOn = true;
    }

    public void SetStopGame()
    {
        isGameOn = false;
        ChangeState(UIState.GameOverUI);
    }

    public void ChangeTime(float time)
    {       
        gameUI.UpdateTime(time);
    }
}
