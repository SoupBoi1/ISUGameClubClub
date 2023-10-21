using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
            Debug.LogError("More Than 1 GameManager in Scene!");
        Instance = this;
    }
}
