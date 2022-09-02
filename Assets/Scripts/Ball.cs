using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 200f;

    private Rigidbody2D rigidbody;
    
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPostion();

    }
    private void AddStarting()
    {
        float x = Random.value <0.5f ?-1.0f :1.0f ;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(-0.5f, -1.0f);

        Vector2 vector2 = new Vector2(x, y);
        rigidbody.AddForce(vector2 * speed) ;
    }
    public void AddForce(Vector2 force) 
    {
        rigidbody.AddForce(force);
    }

    public void ResetPostion()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.position = Vector2.zero;

        AddStarting();
    }
}
