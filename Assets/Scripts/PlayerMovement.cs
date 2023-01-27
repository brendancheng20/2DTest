using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerMovement : MonoBehaviour
{

    private float speed = 10f;
    Rigidbody2D rb; 
    CapsuleCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<CapsuleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision Player");
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1

        Vector2 vector2 = new Vector2(xMove, zMove) * speed;
        rb.velocity = vector2; // Creates velocity in direction of value equal to keypress (WASD).
    }
}
