using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rigidbody;

    protected float speed = 5f;
    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move(moveDirection);
    }

    public void Move(Vector2 direction)
    {
        direction = speed * direction;

        rigidbody.velocity = direction;
    }
}
