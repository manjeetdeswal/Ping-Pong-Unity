using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPaddle : Paddle
{
    public Rigidbody2D ball;


    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        if(this.ball.velocity.x > 0.0f)
        {
            if(this.ball.position.y > transform.position.y)
            {
                rigidbody.AddForce(Vector2.up * speed);
            }
            else if(this.ball.position.y < transform.position.y)
            {
                rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if(transform.position.y > 0.0f)
            {
                rigidbody.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0.0f)
            {
                rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
