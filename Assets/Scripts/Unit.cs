using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Unit : MonoBehaviour
{
    int health = 100;
    int attackDamage = 1;
    int armor = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }

    public void TakeAttack(Transform attacker) {
        int attackDamage = attacker.GetComponent<Unit>().attackDamage;
        health -= Math.Max(attackDamage - (armor / 2), 1);
    }
}
