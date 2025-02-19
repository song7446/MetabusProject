using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : BaseUI
{
    [SerializeField] private TextMeshProUGUI timeText;

    public void UpdateTime(float time)
    {
        timeText.text = time.ToString("N2");
    }

    protected override UIState GetUIState()
    {
        return UIState.GameUI;
    }
}
