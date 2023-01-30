using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControler : MonoBehaviour
{
    public BallMovement ballMovement;
    public ChangeColor changeColor;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;
        
        float paddleHight = c.collider.bounds.size.y;

        float x;
        if(c.gameObject.name == "PaddlePlayer1")
        {
            x = 1;
            changeColor.ChangeColorToSecondColor();
        }
        else
        {
            x = -1;
            changeColor.ChangeColorToFirstColor();
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
        else if(collision.gameObject.name == "LeftWall")
        {
            print("Collision with LeftWall");
        }
        else if (collision.gameObject.name == "RightWall")
        {
            print("Collision with RightWall");
        }
   
    }


}
