using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleController : BaseController
{  
    private void Start()
    {
        // 장애물 방향 조정 
        moveDirection = MiniGameManager.Instance.obstacleManager.endPoint.normalized;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 장애물에 맞는게 플레이어라면 게임 종료 
        if(collision.transform.name == "Player")
        {
            MiniGameManager.Instance.StopGame();
            Destroy(this.gameObject);
        }
        // 벽이라면 장애물 삭제 
        else if(collision.transform.name == "Collision")
        {
            Destroy(this.gameObject);         
        }
    }

    // 장애물 움직임 함수 
    public override void Move(Vector2 direction)
    {
        speed = 10f;
        direction = speed * direction;
        rigidbody.velocity = direction;
    }

    public override void FixedUpdate()
    {
        // 장애물 움직임 
        Move(moveDirection);
    }
}
