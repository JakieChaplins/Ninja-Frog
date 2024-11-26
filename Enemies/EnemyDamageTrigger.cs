using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamageTrigger : MonoBehaviour
{
    [SerializeField] PowerUpsController PowerUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("PlayerCharacter"))
        {
            if (collision.gameObject.GetComponent<PlayerRespawn>().Damaged == false)
            {
                if (collision.gameObject.GetComponent<PowerUpsController>().big == true)
                {
                    collision.gameObject.GetComponent<PlayerRespawn>().PlayerDamaged();
                }
                else
                {
                    collision.gameObject.GetComponent<PlayerRespawn>().PlayerDamaged2();
                }
            }
        }
    }
}
