using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public static Store Instance;

    public Selectable selected;
    public Selectable[] items;

    private void Awake()
    {
        if (Instance != null)
            Debug.LogError("More Than 1 Store in Scene!");
        Instance = this;
    }

    void Update()
    {
        if (selected && Input.GetMouseButtonDown(0))
        {
            selected.Place();
        }
        if (selected && Input.GetMouseButtonDown(1))
        {
            selected.Deselect();
            selected = null;
        }
    }
}
