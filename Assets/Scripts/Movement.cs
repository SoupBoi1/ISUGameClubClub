using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public bool fighting = false;
    public float speed;
    public float row; // Should be half integers, i.e. 0.5, 1.5, 2.5

    private float speedMod = -1.0f;
    private float dir = 1.0f;

    public Animator animator;

    
    private void Awake()
    {
        if (speedMod < 0.0f)
        {
            speedMod = 1.0f - Mathf.Pow(0.9f, Upgrade.speed);
        }

        if (GetComponent<Animator>())
        {
            animator = GetComponent<Animator>();
        }
    }

    private void Start()
    {
        row = transform.position.y;
    }

    void Update()
    {
        if (fighting)
        {
            if (animator != null)
            {
                animator.SetBool("isMelee", fighting);
                animator.SetBool("attacking", fighting)
            }
            return;
        }
        else {

            if (animator != null)
            {
                animator.SetBool("isMelee", fighting);
                animator.SetBool("attacking", fighting)
            }
        }

        if(gameObject.CompareTag("Player"))
        {
            if (animator != null) animator.SetBool("attacking", false);
            if (transform.position.x < Constants.INNERWALL)
            {
                transform.Translate(Vector2.right * (speed + speedMod) * Time.deltaTime);
            }
            else if (transform.position.x > Constants.OUTERWALL)
            {
                if (transform.position.x > Constants.SCREEN_RIGHT)
                {
                    if (transform.position.y > 3.6)
                        dir = -1.0f;
                    else if (transform.position.y < -3.6)
                        dir = 1.0f;
                    transform.Translate(new Vector2(0.0f, dir) * (speed + speedMod) * Time.deltaTime);
                }
                else if (Math.Abs(transform.position.y - row) < 0.1)
                {
                    transform.Translate(Vector2.right * (speed + speedMod) * Time.deltaTime);
                }
                else
                {
                    transform.Translate(new Vector2(0, row).normalized * (speed + speedMod) * Time.deltaTime);
                }
            }
            else if (Mathf.Abs(transform.position.y) < 0.1)
            {
                transform.Translate(Vector2.right * (speed + speedMod) * Time.deltaTime);
            }
            else
            {
                transform.Translate(new Vector2(0, -transform.position.y).normalized * (speed + speedMod) * Time.deltaTime);
            }
        }
        else if (gameObject.CompareTag("Enemy"))
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

        if (transform.position.x < Constants.SCREEN_LEFT) {
            Destroy(this.gameObject);
            GameManager.Instance.LoseLife(1);
        }


        
        

    }
}