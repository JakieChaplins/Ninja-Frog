using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaSpriter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void FlipRocaFalse()
    {
        spriteRenderer.flipX = false;
    }

    public void FlipRocaTrue()
    {
        spriteRenderer.flipX = true;
    }

    public void Jump()
    {
        animator.SetBool("Jump", true);
    }

    public void NoJump()
    { 
        animator.SetBool("Jump", false);
    }
}
