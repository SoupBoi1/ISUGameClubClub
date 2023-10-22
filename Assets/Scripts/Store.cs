using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public static Store Instance;

    public bool canPlace = true;
    public Selectable selected;
    public Selectable[] items;
    public Text[] prices;
    public List<GameObject> factories = new List<GameObject>();

    private float priceMod = -1.0f;

    private void Awake()
    {
        if (Instance != null)
            Debug.LogError("More Than 1 Store in Scene!");
        Instance = this;

        if (priceMod < 0.0f)
        {
            priceMod = .2f + 0.8f * Mathf.Pow(0.9f, Upgrade.price);
        }
    }

    private void Start()
    {
        for(int i = 0; i < items.Length; i++)
        {
            prices[i].text = "" + items[i].cost * (priceMod);
        }
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
        if (selected && Input.GetMouseButtonDown(0) && canPlace)
        {
            if(Money.Instance.getMoney() >= selected.cost * priceMod)
            {
                selected.Place();
                Money.Instance.subMoney(selected.cost * priceMod);
            }
        }
        if (selected && Input.GetMouseButtonDown(1))
        {
            selected.Deselect();
            selected = null;
        }
    }
}
