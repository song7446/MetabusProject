using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    private void OnClickStartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    private void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    protected override UIState GetUIState()
    {
        return UIState.HomeUI;
    }
}
