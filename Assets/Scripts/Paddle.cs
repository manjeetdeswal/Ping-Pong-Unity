using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigidbody;
    public float speed = 10f;
   
    void Awake()
    {



        rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
    }
}
