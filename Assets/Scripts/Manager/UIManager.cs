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

    private float time = 0f;

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
    }

    public void ChangeTime()
    {
        time += Time.deltaTime;
        gameUI.UpdateTime(time);
    }
}
