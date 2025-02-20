using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : BaseUI
{
    // ����� ��ư 
    [SerializeField] private Button restartButton;
    // ���ư��� ��ư 
    [SerializeField] private Button exitButton;
    // ���� �ð� �ؽ�Ʈ 
    [SerializeField] private TextMeshProUGUI curTimeTxt;
    // �ְ� �ð� �ؽ�Ʈ 
    [SerializeField] private TextMeshProUGUI bestTimeTxt;

    public override void Init(UIManager uIManager)
    {
        base.Init(uIManager);

        // ��ư �Լ� �߰� 
        restartButton.onClick.AddListener(OnClickRestartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    // ���� �������� �Լ� 
    protected override UIState GetUIState()
    {
        return UIState.GameOverUI;
    }

    // ����� �Լ� 
    private void OnClickRestartButton()
    {
        MiniGameManager.Instance.StartGame();
    }

    // �������� ���ư��� �Լ� 
    private void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    // ���� �ð� ������Ʈ �Լ� 
    public void SetCurTime(float time)
    {
        curTimeTxt.text = time.ToString("N2");
    }

    // �ְ� �ð� ������Ʈ �Լ� 
    public void SetBestTime(float time)
    {
        bestTimeTxt.text = time.ToString("N2");
    }
}
