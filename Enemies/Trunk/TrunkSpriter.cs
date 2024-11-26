using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunkSpriter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void FlipTrunkFalse()
    {
        spriteRenderer.flipX = false;
    }

    public void FlipTrunkTrue()
    {
        spriteRenderer.flipX = true;
    }

    public void Shooting()
    {
        animator.SetBool("Attack", true);
    }

    public void NoShooting()
    {
        animator.SetBool("Attack", false);
    }
}
