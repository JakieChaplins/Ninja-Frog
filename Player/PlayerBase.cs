using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{

    public Rigidbody2D rb2D;

    public float runSpeed;
    public float jumpSpeed;
    public float trampolineLaunch;
    public float trampolineLaunch2;
    public int jumpNum;

    void Start()
    {      
        rb2D = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        GameObject firstChild = transform.GetChild(0).gameObject;
        firstChild.SetActive(true);

        if (Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && jumpNum > 0)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            jumpNum = jumpNum - 1;
        }
    }

    public void TrampolineLaunch()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, trampolineLaunch);
    }

    public void TrampolineLaunch2()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, trampolineLaunch2);
    }
}
