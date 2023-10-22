using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ClubLights : MonoBehaviour
{

    public Light2D lt;
    public Color[] colors;
    private float timer;
    private int index;
    public float delay = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("changeColors", 0f, 1.5f);
        //colors[0] = Color.white;
        colors[0] = Color.cyan;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        colors[3] = Color.red;
        colors[4] = Color.yellow;
        lt.color = colors[0];
        index = 0;
    }

    void Update()
    {
        
        timer += Time.deltaTime;
        
        if(timer >= delay)
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
        if(index == colors.Length) index = 0;
    }
}
