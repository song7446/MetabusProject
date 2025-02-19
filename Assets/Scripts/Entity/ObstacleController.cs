using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.name == "Player")
        {
            MiniGameManager.Instance.StopGame();
        }
    }
}
