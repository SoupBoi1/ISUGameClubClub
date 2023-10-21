using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool fighting = false;
    public float speed;
    public float row; // Should be half integers, i.e. 0.5, 1.5, 2.5
    void Update()
    {
        if (fighting)
            return;
        if(this.gameObject.CompareTag("Player"))
        {
            if (transform.position.x < Constants.INNERWALL)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else if (transform.position.x > Constants.OUTERWALL)
            {
                if (Math.Abs(transform.position.y - row) < 0.1)
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
        else if (this.gameObject.CompareTag("Enemy"))
        {
            if (transform.position.x > Constants.OUTERWALL)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else if (transform.position.x < Constants.INNERWALL)
            {
                if (Math.Abs(transform.position.y - row) < 0.1)
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