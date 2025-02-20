using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : BaseController
{
    // wasd 이동 
    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>().normalized;       
    }

    // f 상호작용 
    void OnInterAction(InputValue inputValue)
    {       
        if (SceneManager.GetActiveScene().name == "MainScene" && GameManager.Instance.potalController.onPotal)
        {
            SceneManager.LoadScene("MiniGameScene");
        }
    }
}
