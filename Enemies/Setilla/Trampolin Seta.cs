using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolinSeta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            collision.gameObject.GetComponent<PlayerBase>().TrampolineLaunch2();  
        }
    }
}
