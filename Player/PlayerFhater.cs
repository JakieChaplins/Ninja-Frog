using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFhater : MonoBehaviour
{
    [SerializeField] GameObject[] HitBox;

    [SerializeField] PlayerRespawn PR;

    void Start()
    {
        HitBox[0].SetActive(true);
        HitBox[1].SetActive(false);
    }

    void Update()
    {     

        if (PR.Damaged == true)
        {
            HitBox[0].SetActive(false);
            HitBox[1].SetActive(true);
        }
        else
        {
            HitBox[0].SetActive(true);
            HitBox[1].SetActive(false);
        }
    }
}
