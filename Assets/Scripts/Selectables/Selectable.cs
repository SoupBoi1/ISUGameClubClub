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

    public void select()
    {
        if (!preview)
            preview = Instantiate(previewPrefab);
    }
    public void Deselect()
    {
        if (preview)
            Destroy(preview);
    }
    public void Place()
    {
        GameObject obj = Instantiate(prefab);
        obj.transform.position = preview.transform.position;
    }
}
