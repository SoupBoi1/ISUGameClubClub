using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public Movement prefab;
    public float spawnTime;
    public float timer = 0.0f;
    public float row;

    private static float coolDownMod = -1.0f;

    private void Awake()
    {
        if(coolDownMod < 0.0f)
        {
            coolDownMod = Mathf.Pow(0.9f, Upgrade.fCooldown);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > spawnTime * coolDownMod)
        {
            timer = 0.0f;
            Debug.Log(3);
            Movement m = Instantiate(prefab);
            m.row = row;
            m.transform.position = this.transform.position;
        }
    }
}
