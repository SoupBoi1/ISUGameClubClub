using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CopLights : MonoBehaviour
{

    public Light2D lt;
    private Color[] colors = new Color[2];
    private float timer;
    private int index;
    public float delay = 2f;
    public float offset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("changeColors", 0f, 1.5f);
        //colors[0] = Color.white;
        colors[0] = Color.blue;
        colors[1] = Color.red;
        lt.color = colors[0];
        timer = offset;
        index = 0;
    }

    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= delay)
        {
            timer = 0f;
            Debug.Log("changing colors");
            changeColors();
        }

    }

    private void changeColors()
    {

        lt.color = colors[index];
        Debug.Log(lt.color);
        index++;
        if (index == colors.Length) index = 0;
    }
}