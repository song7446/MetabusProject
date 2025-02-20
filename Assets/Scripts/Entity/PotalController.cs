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
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            onPotal = true;
            effect.SetActive(onPotal);
            UIManager.Instance.InterActionTextOnOff(onPotal);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            onPotal = false;
            effect.SetActive(onPotal);
            UIManager.Instance.InterActionTextOnOff(onPotal);
        }
    }
}
