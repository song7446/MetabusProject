using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleController : BaseController
{
    private void Start()
    {
        moveDirection = MiniGameManager.Instance.obstacleManager.endPoint.normalized;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.name == "Player")
        {
            MiniGameManager.Instance.StopGame();
            Destroy(this.gameObject);
        }
        else if(collision.transform.name == "Collision")
        {
            Destroy(this.gameObject);         
        }
    }

    public override void Move(Vector2 direction)
    {
        speed = 10f;
        direction = speed * direction;
        rigidbody.velocity = direction;
    }

    public override void FixedUpdate()
    {
        Move(moveDirection);
    }
}
