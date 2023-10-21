using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Unit : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public int armor;
    public int power;
    public double attackCooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0) {
            Destroy(this.gameObject);
        }
        attackCooldown -= Time.deltaTime;
    }

    public void TakeAttack(Transform attacker) {
        int attackDamage = attacker.GetComponent<Unit>().attackDamage;
        health -= Math.Max(attackDamage - (armor / 2), 1);
    }
}
