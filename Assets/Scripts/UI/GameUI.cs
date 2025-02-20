using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : BaseUI
{
    // �ð� �ؽ�Ʈ 
    [SerializeField] private TextMeshProUGUI timeText;

    // �ð� ���� �Լ� 
    public void UpdateTime(float time)
    {
        timeText.text = time.ToString("N2");
    }

    // ���� �������� �Լ� 
    protected override UIState GetUIState()
    {
        return UIState.GameUI;
    }
}
