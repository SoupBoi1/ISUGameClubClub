using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AttackRange"))
        {
            return;
        }
        // Debug.Log("Projectile " + gameObject.name + " " + collision.gameObject.name);
        string mytag = gameObject.tag;
        string othertag = collision.gameObject.tag;

        if (mytag == "Player" && othertag == "Enemy" || mytag == "Enemy" && othertag == "Player")
        {
            // Debug.Log("Projectile " + gameObject.name + " " + collision.gameObject.name);
            var p = collision.gameObject.transform.parent;
            try
            {
                p.GetComponent<Unit>().TakeAttack(damage);
                Debug.Log("Projectile " + gameObject.name + " " + collision.gameObject.name);
                Destroy(this.gameObject);
            }
            catch (System.NullReferenceException e)
            {
                // Debug.Log("NullReferenceException");
            }

        }

    }
}
