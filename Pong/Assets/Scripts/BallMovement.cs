using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartBall());
    }

    void PositionBall(bool isStartingPlayer1)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        if(isStartingPlayer1)
        {
            gameObject.transform.localPosition= new Vector3(-150,0,10); 
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(150, 0, 10);
        }
    }



    //Setting moving direction by spawn place of the ball
    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        PositionBall(isStartingPlayer1);

        hitCounter = 0;
        yield return new WaitForSeconds(2);
        if(isStartingPlayer1 )
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    //Moving ball
    public void MoveBall(Vector2 dir)
    {
        //Normalized direction
        dir=dir.normalized;

        //Calculating Speed
        float speed = movementSpeed + hitCounter * extraSpeedPerHit;

        //Access to rigidbody
        Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        //Moving ball
        rigidbody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
        if(hitCounter * extraSpeedPerHit <= maxExtraSpeed)
        {
            hitCounter++;
        }
    }


}
