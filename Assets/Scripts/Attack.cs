using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : MonoBehaviour
{
    public CircleCollider2D attackCollider;
    public BoxCollider2D defendCollider;
    int health = 100;
    int attackDamage = 1;
    int armor = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.tag == "Player" && other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Attack>().TakeAttack(attackDamage);
        }
        else if (gameObject.tag == "Enemy" && other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Attack>().TakeAttack(attackDamage);
        }
    }

    public void TakeAttack(int attackDamage) {
        health -= Math.Max(attackDamage - (armor / 2), 1);
    }
}
