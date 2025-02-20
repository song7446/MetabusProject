using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    // 애니메이션 파라미터값 
    private static readonly int moveX = Animator.StringToHash("MoveX");
    private static readonly int moveY = Animator.StringToHash("MoveY");

    protected Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // 이동할 때 단순히 값만 옮기고 애니메이션 간 이동에서 처리 
    public void Move(Vector2 obj)
    {
        animator.SetInteger(moveX, (int)obj.x);
        animator.SetInteger(moveY, (int)obj.y);
    }

}
