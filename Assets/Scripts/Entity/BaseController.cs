using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rigidbody;

    protected float speed = 5f;
    protected Vector2 moveDirection = Vector2.zero;
    public Vector2 MoveDirection { get { return moveDirection; } }

    protected AnimationHandler animationHandler;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animationHandler = GetComponent<AnimationHandler>();
    }

    public virtual void FixedUpdate()
    {
        Move(moveDirection);
    }

    public virtual void Move(Vector2 direction)
    {
        direction = speed * direction;
        rigidbody.velocity = direction;
        animationHandler.Move(direction);
    }
}
