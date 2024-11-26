using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFury2 : MonoBehaviour
{
    public bool checkFury2;

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("PlayerCharacter"))
            {
                checkFury2= true;
            }
        }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            checkFury2 = false;
        }
    }
}
