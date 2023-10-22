using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Selectable : MonoBehaviour
{
    public float cost;
    public GameObject prefab; // Editor assigned
    public GameObject previewPrefab; // Editor assigned
    protected GameObject preview; // Programmically assigned

    public abstract void Move();

    private void Start()
    {
        preview = Instantiate(previewPrefab);
    }
    public void Deselect()
    {
        if (preview)
            Destroy(preview);
        Destroy(gameObject);
    }
    public void Place()
    {
        GameObject obj = Instantiate(prefab);
        obj.transform.position = preview.transform.position;
        if (preview.GetComponent<Placeable>() != null)
        {
            Store.Instance.factories.Add(obj);
        }
    }

    private void Update()
    {
        if (!Store.Instance.canPlace)
            preview.gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f);
        else
            preview.gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f);
        if (preview)
            Move();
    }
}
