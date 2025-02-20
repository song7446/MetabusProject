using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // �ִϸ��̼� �Ķ���Ͱ� 
    private static readonly int moveX = Animator.StringToHash("MoveX");
    private static readonly int moveY = Animator.StringToHash("MoveY");

    protected Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // �̵��� �� �ܼ��� ���� �ű�� �ִϸ��̼� �� �̵����� ó�� 
    public void Move(Vector2 obj)
    {
        animator.SetInteger(moveX, (int)obj.x);
        animator.SetInteger(moveY, (int)obj.y);
    }

}
