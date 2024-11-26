using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] PlayerBase playerBase;

    SpriteRenderer spriteRenderer;
    Animator animator;



    void Start()
    {        
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {     


        if (Input.GetKey("d"))
        {

            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a"))
        {

            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
 
            animator.SetBool("Run", false);
        }

        if (playerBase.jumpNum <= 1 && Input.GetButtonDown("Jump"))
        {
            animator.SetBool("DoubleJump", true);
        }       

        if (CheckGround.isGrounded==false)
        {
                animator.SetBool("Jump", true);
                animator.SetBool("Run", false);
        }

        if (playerBase.rb2D.velocity.y < 0)
        {
            animator.SetBool("Falling", true);
        }
        else
        {
            animator.SetBool("Falling", false);
        }

        if (CheckGround.isGrounded == true)
        {
                animator.SetBool("Jump", false);
                animator.SetBool("DoubleJump", false);
                animator.SetBool("Falling", false);
        }
    }

}
