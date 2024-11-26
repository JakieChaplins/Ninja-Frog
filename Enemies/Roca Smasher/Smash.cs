using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{
    [SerializeField] BaseRoca BR;

    public float cooldownTime =1.5f;

    private float nextFireTime = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            if (Time.time > nextFireTime)
            {
                BR.SmashJump();
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
}
