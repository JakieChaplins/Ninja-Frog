using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkySpriter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    public void FlipPorkyFalse()
    {
        spriteRenderer.flipX = false;
    }

    public void FlipPorkyTrue()
    {
        spriteRenderer.flipX = true;
    }

    public void Fury()
    {
        animator.SetBool("Fury", true);
    }

    public void NoFury()
    {
        animator.SetBool("Fury", false);
    }
}
