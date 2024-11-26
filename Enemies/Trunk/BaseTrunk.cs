using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTrunk : MonoBehaviour
{
    [SerializeField] Check1_2 check1;
    [SerializeField] Check2_2 check2; 
    [SerializeField] Check3_2 check3;
    [SerializeField] Check4_2 check4;
    [SerializeField] Check5_2 check5;
    [SerializeField] Check6_2 check6;
    [SerializeField] CheckShoot1 Shoot;
    [SerializeField] CheckShoot2 Shoot2;
    [SerializeField] TrunkSpriter TSprite;

    Rigidbody2D rb2D;

    public float runSpeed;
    public float jumpSpeed;

    public bool direction;
    private bool ItsShooting;

    private float waitedTime;
    public float waitTimeToAttack = 0.85f;
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public Transform launchSpawnPoint;
    public Transform launchSpawnPoint2;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        direction = false;
        waitedTime = waitTimeToAttack;
    }

    void Update()
    {      
        if (direction == false)
        {
            TSprite.FlipTrunkFalse();


                if (Shoot.checkShoot == true)
                {
                    runSpeed = 0;
                    TSprite.Shooting();

                    if (waitedTime <= 0)
                    {
                        waitedTime = waitTimeToAttack;
                        direction = false;
                        LaunchBullet();
                        
                    }
                    else
                    {
                        waitedTime -= Time.deltaTime;
                    }
                }

                if (Shoot.checkShoot == false)
                {
                    runSpeed = 0.42f;
                    TSprite.NoShooting();
                    
                }

            if (check2.checkYes2 == false)
            {
                if (check1.checkYes == false)
                {
                    if (check3.checkYes3 == true)
                    {
                        rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = true;
                    }
                }
                if (check1.checkYes == true)
                {
                    direction = true;
                }
            }
            else
            {
                if (check1.checkYes == true)
                {
                    direction = true;
                }
                else
                {
                    rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }
        }

        if (direction == true)
        {
            TSprite.FlipTrunkTrue();

                if (Shoot2.checkShoot2 == true)
                {
                    runSpeed = 0;
                    TSprite.Shooting();

                  if (waitedTime <= 0)
                  {
                      waitedTime = waitTimeToAttack;
                      direction = true;
                      LaunchBullet2();                     
                  }
                  else
                  {
                      waitedTime -= Time.deltaTime;
                  }
                }

                if (Shoot2.checkShoot2 == false)
                {
                    runSpeed = 0.42f;
                    TSprite.NoShooting();
                    
                }


            if (check5.checkYes5 == false)
            {
                if (check4.checkYes4 == false)
                {
                    if (check6.checkYes6 == true)
                    {
                        rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    }
                    else
                    {
                        direction = false;
                    }
                }
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
            }
            else
            {
                if (check4.checkYes4 == true)
                {
                    direction = false;
                }
                else
                {
                    rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                }
            }           
        }     
    }

    public void LaunchBullet()
    {
        GameObject newBullet;

        newBullet = Instantiate(bulletPrefab, launchSpawnPoint.position, launchSpawnPoint.rotation);
    }

    public void LaunchBullet2()
    {
        GameObject newBullet;

        newBullet = Instantiate(bulletPrefab2, launchSpawnPoint2.position, launchSpawnPoint2.rotation);
    }
}
