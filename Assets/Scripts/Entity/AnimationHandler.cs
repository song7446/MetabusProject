using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int isMoveX = Animator.StringToHash("IsMoveX");
    private static readonly int isMoveY = Animator.StringToHash("IsMoveY");

    protected Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetInteger(isMoveX, (int)obj.x);
        animator.SetInteger(isMoveY, (int)obj.y);
    }

}
