using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    // ���� ��ư
    [SerializeField] private Button startButton;

    // ���� ��ư
    [SerializeField] private Button exitButton;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        // ��ư �Լ� �߰� 
        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    // ���� ���� �Լ� 
    private void OnClickStartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    // �������� ���ư��� �Լ� 
    private void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    // ���� �������� �Լ� 
    protected override UIState GetUIState()
    {
        return UIState.HomeUI;
    }
}
