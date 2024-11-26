using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFury : MonoBehaviour
{
    public bool checkFury;

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("PlayerCharacter"))
            {
                checkFury= true;
            }
        }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            checkFury = false;
        }
    }
}
