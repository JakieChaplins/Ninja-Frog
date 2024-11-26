using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsController : MonoBehaviour
{
    public bool big;
    public bool weapon;

    void Start()
    {
        big = false;
        weapon = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    void Update()
    {
        if (big == false)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void Orange()
    {
        big = true; 
        transform.localScale = new Vector3(1.15f, 1.22f, 1);
    }

    public void Kiwi()
    {
        weapon = true;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
}
