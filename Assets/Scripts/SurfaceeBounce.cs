using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceeBounce : MonoBehaviour
{
    public float bounceStregth;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if(ball == null)
        {
            return;

        }
        else
        {
            Vector2 vector = collision.GetContact(0).normal;
            ball.AddForce(-vector * bounceStregth);
        }

    }
   
}
