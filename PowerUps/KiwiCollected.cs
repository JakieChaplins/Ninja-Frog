using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiwiCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCharacter"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            collision.gameObject.GetComponent<PowerUpsController>().Kiwi();
        }
    }
}
