using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int life;

    public 

    private void Awake()
    {
        if (Instance != null)
            Debug.LogError("More Than 1 GameManager in Scene!");
        Instance = this;
    }

    void Start()
    {
        life = 100;
    }

    public void LoseLife(int amt)
    {
        life -= amt;

        if (life <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
    }
}
