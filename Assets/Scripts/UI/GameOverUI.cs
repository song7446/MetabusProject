using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : BaseUI
{
    [SerializeField] private Button restartButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private TextMeshProUGUI curTimeTxt;
    [SerializeField] private TextMeshProUGUI bestTimeTxt;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        restartButton.onClick.AddListener(OnClickRestartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    protected override UIState GetUIState()
    {
        return UIState.GameOverUI;
    }

    private void OnClickRestartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    private void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SetCurTime(float time)
    {
        curTimeTxt.text = time.ToString("N2");
    }

    public void SetBestTime(float time)
    {
        bestTimeTxt.text = time.ToString("N2");
    }
}
