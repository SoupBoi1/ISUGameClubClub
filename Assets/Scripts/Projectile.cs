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

        if (transform.position.x > Constants.SCREEN_RIGHT || transform.position.x < Constants.SCREEN_LEFT || transform.position.y > 10 || transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
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
            var p = collision.gameObject;

            try {
            int rem = p.GetComponent<Unit>().TakeAttack(damage);
            } catch (System.Exception e) {
                Debug.Log(e);
            }
            Destroy(this.gameObject);


        }

    }
}
