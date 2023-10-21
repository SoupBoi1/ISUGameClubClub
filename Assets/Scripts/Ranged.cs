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
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (gameObject.tag == "Defense")
        {
            return;
        }

        string mytag = gameObject.transform.parent.gameObject.tag;
        string othertag = other.gameObject.transform.parent.gameObject.tag;

        if (mytag == "Player" && othertag == "Enemy" || mytag == "Enemy" && othertag == "Player")
        {
            Projectile p = Instantiate(projectile, gameObject.transform.position, Quaternion.identity);
            
            p.direction = (other.gameObject.transform.parent.position - gameObject.transform.parent.position).normalized;
        }
    }
}
