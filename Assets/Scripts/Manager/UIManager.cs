using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject interActionTextOBj;
    private bool isOninterAction = false;
    private void Awake()
    {
        Instance = this;
    }

    public void InterActionTextOnOff()
    {
        isOninterAction = !isOninterAction;
        interActionTextOBj.SetActive(isOninterAction);
    }
}
