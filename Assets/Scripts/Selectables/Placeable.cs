using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
    private void Update()
    {
        for(int i = 0; i < Store.Instance.factories.Count; i++)
        {
            if(!Store.Instance.factories[i])
            {
                Store.Instance.factories.RemoveAt(i--);
                continue;
            }
            if (Store.Instance.factories[i].transform.position.x == transform.position.x && 
                Store.Instance.factories[i].transform.position.y == transform.position.y)
            {
                Store.Instance.canPlace = false;
                return;
            }
        }
        Store.Instance.canPlace = true;
    }
}
