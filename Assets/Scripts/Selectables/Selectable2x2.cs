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
        Vector2 loc = Input.mousePosition;
        loc.x = (int)loc.x;
        loc.y = (int)loc.y;
        preview.transform.position = loc;
    }
}
