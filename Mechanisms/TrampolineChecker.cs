using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineChecker : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            animator.Play("Trampoline");
            collision.gameObject.GetComponent<PlayerBase>().TrampolineLaunch();
        } 
    }
}
