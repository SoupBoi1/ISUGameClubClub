using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Unit : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public int armor;
    public float attackCooldown;
    public Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Unit spawned");
    }

    void Update()
    {
        if (health <= 0) {
            Destroy(this.gameObject);
        }
        attackCooldown -= Time.deltaTime;
    }

    public bool CanAttack() {
        return attackCooldown <= 0;
    }

    public void TakeAttack(int attackDamage) {
        health -= Math.Max(attackDamage - (armor / 2), 1);
        Debug.Log("Unit took " + Math.Max(attackDamage - (armor / 2), 1) + " damage. Current health: " + health);
    }
}