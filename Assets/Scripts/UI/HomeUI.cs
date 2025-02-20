using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    // 시작 버튼
    [SerializeField] private Button startButton;

    // 종료 버튼
    [SerializeField] private Button exitButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        // 버튼 함수 추가 
        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    // 게임 시작 함수 
    private void OnClickStartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    // 메인으로 돌아가기 함수 
    private void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    // 상태 가져오기 함수 
    protected override UIState GetUIState()
    {
        return UIState.HomeUI;
    }
}
