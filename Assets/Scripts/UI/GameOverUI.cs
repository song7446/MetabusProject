using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : BaseUI
{
    // 재시작 버튼 
    [SerializeField] private Button restartButton;
    // 돌아가기 버튼 
    [SerializeField] private Button exitButton;
    // 현재 시간 텍스트 
    [SerializeField] private TextMeshProUGUI curTimeTxt;
    // 최고 시간 텍스트 
    [SerializeField] private TextMeshProUGUI bestTimeTxt;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        // 버튼 함수 추가 
        restartButton.onClick.AddListener(OnClickRestartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    // 상태 가져오기 함수 
    protected override UIState GetUIState()
    {
        return UIState.GameOverUI;
    }

    // 재시작 함수 
    private void OnClickRestartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    // 메인으로 돌아가기 함수 
    private void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    // 현재 시간 업데이트 함수 
    public void SetCurTime(float time)
    {
        curTimeTxt.text = time.ToString("N2");
    }

    // 최고 시간 업데이트 함수 
    public void SetBestTime(float time)
    {
        bestTimeTxt.text = time.ToString("N2");
    }
}
