using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public Movement prefab;
    public float spawnTime;
    public float timer;
    public float row;

    private void Start()
    {
        timer = spawnTime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0.0f)
        {
            timer = spawnTime;
            Movement m = Instantiate(prefab);
            m.row = row;
            m.transform.position = this.transform.position;
        }
    }
}
