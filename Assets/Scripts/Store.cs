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

    public void SelectClubber()
    {
        if (selected)
            selected.Deselect();
        selected = Instantiate(items[0]);
    }
    public void SelectThrower()
    {
        if (selected)
            selected.Deselect();
        selected = Instantiate(items[1]);
    }
    public void SelectClubberFactory()
    {
        if (selected)
            selected.Deselect();
        selected = Instantiate(items[2]);
    }
    public void SelectThrowerFactory()
    {
        if (selected)
            selected.Deselect();
        selected = Instantiate(items[3]);
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
