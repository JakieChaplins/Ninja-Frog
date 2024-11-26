using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovilPlatforms : MonoBehaviour
{ 
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        targetPoint = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[targetPoint].position)
        {
            increaseTargetInt();
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].transform.position, speed * Time.deltaTime);
    }

    void increaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);

        if (collision.transform.CompareTag("PlayerCharacter"))
        {
            CheckGround.isGrounded = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }
}
