using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{
    public CircleCollider2D collider;

    void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.tag == "Defense")
        {
            return;
        }

        string mytag = gameObject.transform.parent.gameObject.tag;
        string othertag = other.gameObject.transform.parent.gameObject.tag;

        if (mytag == "Player" && othertag == "Enemy" || mytag == "Enemy" && othertag == "Player")
        {
            other.gameObject.GetComponent<Unit>().TakeAttack(other.gameObject.transform.parent);
        }
    }
}
