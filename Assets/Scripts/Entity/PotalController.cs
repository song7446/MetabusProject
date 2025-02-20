using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotalController : MonoBehaviour
{
    [SerializeField] protected GameObject effect;
    public bool onPotal = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onPotal = true;
        effect.SetActive(onPotal);
        UIManager.Instance.InterActionTextOnOff(onPotal);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onPotal = false;
        effect.SetActive(onPotal);
        UIManager.Instance.InterActionTextOnOff(onPotal);
    }
}
