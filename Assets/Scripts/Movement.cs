using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private static float innerWall = -0.5f;
    private static float outerWall = 0.5f;
    private static float lowerWall = -1.0f;
    private static float upperWall = 1.0f;

    public bool fighting = false;
    public float speed;
    public Transform transform;
    public float row; // Should be half integers, i.e. 0.5, 1.5, 2.5
    void Update()
    {
        if (fighting)
            return;
        if(this.gameObject.CompareTag("Player"))
        {
            if (transform.position.x < innerWall)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else if (transform.position.x > outerWall)
            {
                if (Math.Abs(transform.position.y) - row < 0.1)
                {
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(new Vector2(0, row).normalized * speed * Time.deltaTime);
                }
            }
            else if (Mathf.Abs(transform.position.y) < 0.1)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(new Vector2(0, -row).normalized * speed * Time.deltaTime);
            }
        }
        else
        {
            if (transform.position.x > outerWall)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else if (transform.position.x < innerWall)
            {
                if (Math.Abs(transform.position.y) - row < 0.1)
                {
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(new Vector2(0, row).normalized * speed * Time.deltaTime);
                }
            }
            else if (Mathf.Abs(transform.position.y) < 0.1)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(new Vector2(0, -row).normalized * speed * Time.deltaTime);
            }
        }
    }
}
