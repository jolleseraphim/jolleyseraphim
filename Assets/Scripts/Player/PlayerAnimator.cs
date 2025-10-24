using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetMovementAnimation(float speed)
    {
        animator.SetFloat("Speed", speed);
    }

    public void SetKickAnimation(bool isKicking)
    {
        animator.SetBool("IsKicking", isKicking);
    }

    public void SetJumpAnimation(bool isJumping)
    {
        animator.SetBool("IsJumping", isJumping);
    }

    public void SetCelebrateAnimation(bool isCelebrating)
    {
        animator.SetBool("IsCelebrating", isCelebrating);
    }
}