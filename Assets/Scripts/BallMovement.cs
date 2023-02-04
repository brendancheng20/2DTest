using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallMovement : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        System.Random rnd = new System.Random();
        float x = rnd.Next(1,5);
        float y = rnd.Next(1,5);
        rb.velocity = new Vector2(x,y);
        rb.velocity = 10*rb.velocity.normalized;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Vector2 norm = col.GetContact(col.contactCount/2).normal;
        float dot = Vector2.Dot(rb.velocity, norm.normalized);
        if (dot < 0)
            rb.velocity = rb.velocity - 2*(dot)*norm.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
