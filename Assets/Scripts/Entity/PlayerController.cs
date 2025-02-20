using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : BaseController
{
    // wasd �̵� 
    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>().normalized;       
    }

    // f ��ȣ�ۿ� 
    void OnInterAction(InputValue inputValue)
    {       
        if (SceneManager.GetActiveScene().name == "MainScene" && GameManager.Instance.potalController.onPotal)
        {
            SceneManager.LoadScene("MiniGameScene");
        }
    }
}
