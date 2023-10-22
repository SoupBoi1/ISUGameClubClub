using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : MonoBehaviour
{
    public Projectile projectile;
    public Unit unit;

    // Start is called before the first frame update
    void Start()
    {
        unit = gameObject.transform.parent.gameObject.GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("AttackRange")) {
            return;
        }
        // Debug.Log("Ranged " + gameObject.name + " " + other.gameObject.name);
        string mytag = gameObject.transform.parent.gameObject.tag;
        string othertag = other.gameObject.tag;

        if (mytag == "Player" && othertag == "Enemy" || mytag == "Enemy" && othertag == "Player")
        {
            if (!unit.CanAttack())
            {
                return;
            }

            unit.attackCooldown = 1.0f;

            Projectile p = Instantiate(projectile, gameObject.transform.position, Quaternion.identity);
            
            p.direction = (other.gameObject.transform.position - gameObject.transform.parent.position).normalized;
        }
    }
}
