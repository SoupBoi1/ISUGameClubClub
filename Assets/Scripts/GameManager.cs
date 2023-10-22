using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int life;

    public float tutTimer = 0;
    public int step = 0;
    public GameObject buyMessage;
    public GameObject insideShopMessage;
    public GameObject outsideShopMessage;
    public GameObject partingMessage;

    private void Awake()
    {
        if (Instance != null)
            Debug.LogError("More Than 1 GameManager in Scene!");
        Instance = this;
    }

    void Start()
    {
        life = 100;
        if(Upgrade.firstTime)
        {
            step = 1;
            Upgrade.firstTime = false;
            buyMessage.SetActive(true);
            Pause();
        }
    }

    private void Update()
    {
        if (GameManager.Instance.step == 4)
        {
            tutTimer += Time.deltaTime;
            if (tutTimer > 5.0f)
            {
                GameManager.Instance.partingMessage.SetActive(false);
                GameManager.Instance.step = 5;
            }
        }
    }

    public void LoseLife(int amt)
    {
        life -= amt;

        if (life <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("death");
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
