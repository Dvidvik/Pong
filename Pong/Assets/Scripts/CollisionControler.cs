using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour
{
    public BallMovement ballMovement;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        
        float paddleHight = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "PaddlePlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / paddleHight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(x,y));

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "PaddlePlayer1" || collision.gameObject.name == "PaddlePlayer2")
        {
            BounceFromRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            print("Collision with WallLeft");
        }
        else if (collision.gameObject.name == "WallRight")
        {
            print("Collision with WallRight");
        }
   
    }


}
