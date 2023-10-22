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
    public float startCooldown;
    public Movement movement;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0) {
            Debug.Log(gameObject.name + " died");
            if (gameObject.transform.childCount > 0) {
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }
            Destroy(this.gameObject);
        }
        attackCooldown -= Time.deltaTime;
    }

    public bool CanAttack() {
        return attackCooldown <= 0;
    }

    public int TakeAttack(int attackDamage) {
        health -= Math.Max(attackDamage - (armor / 2), 1);
        // Debug.Log("Unit took " + Math.Max(attackDamage - (armor / 2), 1) + " damage. Current health: " + health);
        return health;
    }

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Enemy")) {
            TakeAttack(10);
        }
    }
}