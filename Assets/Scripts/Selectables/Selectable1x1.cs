using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Selectable1x1 : Selectable
{
    public override void Move()
    {
        Vector2 loc = Input.mousePosition;
        loc.x = (int)(loc.x + 0.5f) + 0.5f;
        loc.y = (int)(loc.y + 0.5f) + 0.5f;
        preview.transform.position = loc;
    }
}
