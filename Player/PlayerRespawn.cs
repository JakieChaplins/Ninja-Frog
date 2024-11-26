using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public bool Damaged;
   
    public Animator animator;

    void Start()
    {
        Damaged = false;
    }

    public void PlayerDamaged()
    {
        animator.SetBool("Hit", true);
        if (gameObject.GetComponent<PowerUpsController>().big == true)
        {
            Debug.Log("Auch");
            gameObject.GetComponent<PowerUpsController>().big = false;
            Invoke("Hitted", 1);
            Invoke("DamagedM", 2);
        }
        Damaged = true;
    }

    public void PlayerDamaged2()
    {
        Debug.Log("Muero");
        animator.SetBool("Hit", true);
        Invoke("CargarScene", 0.5f);

    }

    public void CargarScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Hitted()
    {
        animator.SetBool("Hit", false);
    }

    public void DamagedM()
    {
        Damaged = false;
    }
}
