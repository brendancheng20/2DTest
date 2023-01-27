using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
public class CameraBoundary : MonoBehaviour
{
    public Camera Cam;
    public EdgeCollider2D Edge;
 
    void Start()
    {

        Cam = GetComponent<Camera>();
        Edge = GetComponent<EdgeCollider2D>();

        if (!Cam.orthographic)
        {
            Debug.LogError("Camera must be Orthographic.");
            return;
        }
 
        var aspect = (float)Screen.width / Screen.height;
        var orthoSize = Cam.orthographicSize;

        var width = 2.0f * orthoSize * aspect;
        var height = 2.0f * Cam.orthographicSize;

        Vector2 ur = Cam.ViewportToWorldPoint(new Vector3(1,1,Cam.farClipPlane));
        Vector2 ul = new Vector2(ur.x - width, ur.y);
        Vector2 lr = new Vector2(ur.x, ur.y - height);
        Vector2 ll = new Vector2(ur.x - width, ur.y - height);

        List<Vector2> points = new List<Vector2>();
        points.Add(ur);
        points.Add(lr);
        points.Add(ll);
        points.Add(ul);
        points.Add(ur);

        Edge.SetPoints(points);
 
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision Cam");
    }

    void Update()
    {
        
    }

}