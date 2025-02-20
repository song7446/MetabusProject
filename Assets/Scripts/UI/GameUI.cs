using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : BaseUI
{
    // 시간 텍스트 
    [SerializeField] private TextMeshProUGUI timeText;

    // 시간 변경 함수 
    public void UpdateTime(float time)
    {
        timeText.text = time.ToString("N2");
    }

    // 상태 가져오기 함수 
    protected override UIState GetUIState()
    {
        return UIState.GameUI;
    }
}
