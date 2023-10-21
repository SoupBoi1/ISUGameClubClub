using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int difficulty;
    public Movement[] prefabs;
    public float trickleBoostWait;
    public float trickleDelay;
    public float waveWait;

    private float trickleBoostTimer = 0;
    private float trickleDelayTimer = 0;
    private float waveTimer = 0;

    public float power = 0;
    private float subWave = 0;
    private float maxSubWave = 2;

    private void Start()
    {
    }

    private void Update()
    {
        trickleTick();
        waveTick();
    }

    float getWavePower()
    {
        return 0.01f * Mathf.Pow(Time.timeSinceLevelLoad, 1.5f + difficulty * 0.01f);
    }

    float getTricklePower()
    {
        return 0.01f * Mathf.Pow(Time.timeSinceLevelLoad, 1.5f + difficulty * 0.01f);
    }

    void trickleTick()
    {
        trickleDelayTimer += Time.deltaTime;
        trickleBoostTimer += Time.deltaTime;
        if (trickleBoostTimer > trickleBoostWait)
        {
            trickleBoostTimer = 0;
            power += getTricklePower();
        }
        if (trickleDelayTimer < trickleDelay)
            return;
        trickleDelayTimer = 0.0f;
        trickleSpawn();
    }
    void waveTick()
    {
        waveTimer += Time.deltaTime;
        if (subWave == 0 && waveTimer < waveWait)
            return;
        if (waveTimer > 1.0f)
        {
            power += getWavePower() * (subWave / maxSubWave);
            waveTimer = 0.0f;
        }
        if (subWave >= maxSubWave)
            subWave = 0;
    }

    private void trickleSpawn()
    {
        if(power > 0.0f)
        {
            int rand = UnityEngine.Random.Range(0, prefabs.Length);
            spawnEnemy(rand);
            power -= rand + 1.0f;
        }
    }

    private void spawnEnemy(int index)
    {
        Movement e = Instantiate(prefabs[0]);
        e.row = Mathf.Round(UnityEngine.Random.Range(-3.0f, 4.0f)) - 0.5f;
        e.transform.position = new Vector2(Constants.SCREEN_RIGHT, e.row);
    }
}
