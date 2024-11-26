using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePorky : MonoBehaviour
{
    [SerializeField] Check1 check1;
    [SerializeField] Check2 check2; 
    [SerializeField] Check3 check3;
    [SerializeField] Check4 check4;
    [SerializeField] Check5 check5;
    [SerializeField] Check6 check6;
    [SerializeField] CheckFury Fury;
    [SerializeField] CheckFury2 Fury2;
    [SerializeField] PorkySpriter PSprite;

    Rigidbody2D rb2D;

    public float runSpeed;
    public float jumpSpeed;

    private bool direction;
    private bool ItsFury;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        direction = false;
        ItsFury = false;
    }

    void Update()
    {
        if (direction == false)
        {
            PSprite.FlipPorkyFalse();
            if (check2.checkYes2 == false)
            {
                if (check1.checkYes == false)
                {
                    if (check3.checkYes3 == true)
                    {
                        rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = true;
                    }
                }
                if (check1.checkYes == true)
                {
                    direction = true;
                }
            }
            else
            {
                if (check1.checkYes == true)
                {
                    direction = true;
                }
                else
                {
                    rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }

            if (ItsFury == false)
            {
                if (Fury.checkFury == true)
                {
                    runSpeed = runSpeed * 1.7f;
                    PSprite.Fury();
                    ItsFury = true;
                }
            }
            if (ItsFury == true)
            {
                if (Fury.checkFury == false)
                {
                    runSpeed = runSpeed / 1.7f;
                    PSprite.NoFury();
                    ItsFury = false;
                }
            }
        }

        if (direction == true)
        {
            PSprite.FlipPorkyTrue();
            if (check5.checkYes5 == false)
            {
                if (check4.checkYes4 == false)
                {
                    if (check6.checkYes6 == true)
                    {
                        rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = false;
                    }
                }
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
            }
            else
            {
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
                else
                {
                    rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }

            if (ItsFury == false)
            {
                if (Fury2.checkFury2 == true)
                {
                    runSpeed = runSpeed * 1.7f;
                    PSprite.Fury();
                    ItsFury = true;
                }
            }
            if (ItsFury == true)
            {
                if (Fury2.checkFury2 == false)
                {
                    runSpeed = runSpeed / 1.7f;
                    PSprite.NoFury();
                    ItsFury = false;
                }
            }
        }     
    }
}
