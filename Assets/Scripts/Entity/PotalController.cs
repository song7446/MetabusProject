using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotalController : MonoBehaviour
{
    // ��Ż ȿ�� ������Ʈ 
    [SerializeField] protected GameObject effect;

    // ��Ż ���� �ִ��� ������ Ȯ�� �ϴ� �Ҹ��� ��
    public bool onPotal = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ��Ż ���� �ִٸ� true 
        onPotal = true;
        // ��Ż �� ȿ�� ������Ʈ Ȱ��ȭ 
        effect.SetActive(onPotal);
        // ��Ż ��ȣ�ۿ� ���� �ؽ�Ʈ Ȱ��ȭ 
        UIManager.Instance.InterActionTextOnOff(onPotal);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // ��Ż ���� ���ٸ� false 
        onPotal = false;
        // ��Ż �� ȿ�� ������Ʈ ��Ȱ��ȭ 
        effect.SetActive(onPotal);
        // ��Ż ��ȣ�ۿ� ���� �ؽ�Ʈ ��Ȱ��ȭ 
        UIManager.Instance.InterActionTextOnOff(onPotal);
    }
}
