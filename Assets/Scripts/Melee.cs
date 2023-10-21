using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{
    public CircleCollider2D collider;

    void OnTriggerStay2D(Collider2D other)
    {
                    Debug.Log("Attack" + other.gameObject.transform.parent.gameObject.name);
        bool mytag = gameObject.transform.parent.gameObject.CompareTag("Player");
        bool othertag = other.gameObject.transform.parent.gameObject.CompareTag("Player");
        if (mytag != othertag)
        {
            other.gameObject.GetComponent<Unit>().TakeAttack(other.gameObject.transform.parent);
        }
    }

    
}
