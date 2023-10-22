using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : MonoBehaviour
{
    public Projectile projectile;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.parent.GetComponent<Unit>().CanAttack())
        {
            gameObject.transform.parent.GetComponent<Unit>().movement.fighting = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("AttackRange"))
        {
            return;
        }
        // Debug.Log("Ranged " + gameObject.name + " " + other.gameObject.name);
        bool mytag = gameObject.transform.parent.CompareTag("Player");
        bool othertag = other.gameObject.CompareTag("Player");

        if (mytag != othertag)
        {
            if (!gameObject.transform.parent.GetComponent<Unit>().CanAttack())
            {
                return;
            }

            gameObject.transform.parent.GetComponent<Unit>().attackCooldown = gameObject.transform.parent.GetComponent<Unit>().startCooldown;
            gameObject.transform.parent.GetComponent<Unit>().movement.fighting = true;
            // Debug.Log(4);
            Projectile p = Instantiate(projectile, gameObject.transform.parent.position, Quaternion.identity);
            p.tag = gameObject.transform.parent.tag;
            p.direction = (other.gameObject.transform.position - gameObject.transform.parent.position).normalized;
        }
    }
}
