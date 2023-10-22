using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritesize : MonoBehaviour
{
    public SpriteRenderer sprRend;
    
    // Start is called before the first frame update
    void Start()
    {
        sprRend.size = new Vector2(0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
