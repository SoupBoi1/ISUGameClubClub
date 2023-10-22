using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixSpritRender : MonoBehaviour
{
    private SpriteRenderer sprRend;

    public float x =0.05f;
    public float y= 0.05f;


    // Start is called before the first frame update
    void Awake()
    {
        sprRend = GetComponent<SpriteRenderer>();
        sprRend.drawMode = SpriteDrawMode.Sliced;
        //gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("image256x128");

        sprRend.size = new Vector2(x, y);

    }
    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
        sprRend.drawMode = SpriteDrawMode.Sliced;
       // gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("image256x128");

        sprRend.size = new Vector2(x, y);

    }

    // Update is called once per frame
    void Update()
    {
        sprRend.size = new Vector2(x, y);
    }
}
