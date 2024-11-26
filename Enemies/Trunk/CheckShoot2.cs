using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckShoot2 : MonoBehaviour
{
    public bool checkShoot2;

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("PlayerCharacter"))
            {
                checkShoot2= true;
            }
        }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            checkShoot2 = false;
        }
    }
}
