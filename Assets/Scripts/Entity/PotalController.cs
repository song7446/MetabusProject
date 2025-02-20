using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotalController : MonoBehaviour
{
    // 포탈 효과 오브젝트 
    [SerializeField] protected GameObject effect;

    // 포탈 위에 있는지 없는지 확인 하는 불리언 값
    public bool onPotal = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 포탈 위에 있다면 true 
        onPotal = true;
        // 포탈 위 효과 오브젝트 활성화 
        effect.SetActive(onPotal);
        // 포탈 상호작용 설명 텍스트 활성화 
        UIManager.Instance.InterActionTextOnOff(onPotal);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // 포탈 위에 없다면 false 
        onPotal = false;
        // 포탈 위 효과 오브젝트 비활성화 
        effect.SetActive(onPotal);
        // 포탈 상호작용 설명 텍스트 비활성화 
        UIManager.Instance.InterActionTextOnOff(onPotal);
    }
}
