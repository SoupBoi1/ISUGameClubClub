using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Selectable2x2 : Selectable
{   
    public override void Move()
    {
        Vector3 loc = Input.mousePosition;
        loc.z = 18.0f;
        loc = Camera.main.ScreenToWorldPoint(loc);
        loc.x = Mathf.Floor(Mathf.Min(Mathf.Max(loc.x, -5.0f), -1.0f)) + 0.5f;
        loc.y = Mathf.Floor(Mathf.Min(Mathf.Max(loc.y, -4.0f), 3.0f)) + 0.5f;
        preview.transform.position = loc;
    }
}
