using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Attack " + other.gameObject.name);
        bool mytag = gameObject.CompareTag("Player");
        bool othertag = other.gameObject.CompareTag("Player");
        if (mytag != othertag)
        {
            other.gameObject.GetComponent<Unit>().TakeAttack(gameObject.GetComponent<Unit>().attackDamage);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
                    Debug.Log("Attack " + other.gameObject.name);
        bool mytag = gameObject.CompareTag("Player");
        bool othertag = other.gameObject.CompareTag("Player");
        if (mytag != othertag)
        {
            other.gameObject.GetComponent<Unit>().TakeAttack(gameObject.GetComponent<Unit>().attackDamage);
        }
    }

    
}
