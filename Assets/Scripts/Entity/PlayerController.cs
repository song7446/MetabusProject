using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : BaseController
{

    void OnMove(InputValue inputValue)
    {
        moveDirection = inputValue.Get<Vector2>().normalized;       
    }

    void OnInterAction(InputValue inputValue)
    {       
        if (GameManager.Instance.potalController.onPotal)
        {
            SceneManager.LoadScene("MiniGameScene");
        }
    }

    void OnJump(InputValue inputValue)
    {     
        
    }
}
