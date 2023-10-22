using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{

    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     Debug.Log("Attack " + other.gameObject.name);
    //     bool mytag = gameObject.CompareTag("Player");
    //     bool othertag = other.gameObject.CompareTag("Player");
    //     if (mytag != othertag)
    //     {
    //         other.gameObject.GetComponent<Unit>().TakeAttack(gameObject.GetComponent<Unit>().attackDamage);
    //     }
    // }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("AttackRange")) {
            return;
        }


                    // Debug.Log("Attack " + gameObject.name + " " + other.gameObject.name);
        bool mytag = gameObject.CompareTag("Player");
        bool othertag = other.gameObject.CompareTag("Player");
        if (mytag != othertag)
        {
            var p = other.gameObject.transform.parent;
            try {
                int rem_health = p.GetComponent<Unit>().TakeAttack(gameObject.GetComponent<Unit>().attackDamage);
                if (rem_health > 0) {
                    gameObject.transform.parent.GetComponent<Unit>().movement.fighting = true;
                } else {
                    gameObject.transform.parent.GetComponent<Unit>().movement.fighting = false;
                }
            } catch (NullReferenceException e) {
                // Debug.Log("NullReferenceException");
            }
            // int attackDamage = gameObject.transform.parent.GetComponent<Unit>().attackDamage;
            // // gameObject.transform.parent.GetComponent<Unit>().attackDamage
            // p.GetComponent<Unit>().TakeAttack(attackDamage);
        }
    }

    
}
