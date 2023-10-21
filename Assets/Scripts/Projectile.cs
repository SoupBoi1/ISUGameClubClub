using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Collider2D collider;
    public Vector2 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        string mytag = gameObject.transform.parent.gameObject.tag;
        string othertag = collision.gameObject.transform.parent.gameObject.tag;

        if (mytag == "Player" && othertag == "Enemy" || mytag == "Enemy" && othertag == "Player")
        {
            collision.gameObject.GetComponent<Unit>().TakeAttack(collision.gameObject.transform.parent);
        }
    }
}
