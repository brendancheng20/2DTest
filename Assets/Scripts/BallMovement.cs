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
        float x = rnd.Next(0,5);
        float y = rnd.Next(0,5);
        rb.velocity = new Vector2(x,y);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        rb.velocity = -1*rb.velocity;
        Debug.Log("Collision Ball");
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("help");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
