using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check3_2 : MonoBehaviour
{
    public bool checkYes3;


        void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                checkYes3 = true;
            }
        }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            checkYes3 = false;
        }
    }
}
