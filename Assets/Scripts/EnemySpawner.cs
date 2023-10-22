using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int difficulty;

    public PriorityRow[] prefabTiers;
    public PriorityRow[] prefabBossTiers;

    public float trickleWaveWait;
    public float trickleDelay;
    public float waveWait;

    private float trickleWaveTimer = 0;
    private float trickleDelayTimer = 0;
    private float waveTimer = 0;

    private float power = 0;
    private float subWave = 0;
    private float maxSubWave = 2;

    [System.SerializableAttribute]
    public class PriorityRow
    {
        public int power;
        public Movement[] members;
    }

    private void Start()
    {
    }

    private void Update()
    {
        trickleWaveWait = 1.5f + 0.5f * MathF.Sin(Time.timeSinceLevelLoad);
        trickleTick();
        waveTick();
    }

    float getWavePower()
    {
        return 0.01f * Mathf.Pow(Time.timeSinceLevelLoad, 1.5f + difficulty * 0.01f);
    }

    float getTricklePower()
    {
        return 0.01f * Mathf.Pow(Time.timeSinceLevelLoad, 1.1f + difficulty * 0.01f);
    }

    void trickleTick()
    {
        trickleDelayTimer += Time.deltaTime;
        trickleWaveTimer += Time.deltaTime;
        if (trickleWaveTimer > trickleWaveWait)
        {
            trickleWaveTimer = 0;
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
            power += getWavePower() * (subWave++ / maxSubWave);
            waveTimer = 0.0f;
        }
        if (subWave >= maxSubWave)
        {
            subWave = 0;
            float bPower = getWavePower();
            while(bPower > 0.0f)
            {
                int tier = Math.Min((int)bPower, prefabBossTiers.Length-1);
                spawnEnemy(tier, true);
                bPower -= prefabBossTiers[tier].power;
            }
        }
    }

    private void trickleSpawn()
    {
        if(power > 0.0f)
        {
            int rTier = UnityEngine.Random.Range(0, Math.Min((int)power, prefabTiers.Length-1));
            spawnEnemy(rTier, false);
            power -= prefabTiers[rTier].power;
        }
    }

    private void spawnEnemy(int tier, bool boss)
    {
        Movement e;
        if (!boss)
        {
            int unit = UnityEngine.Random.Range(0, prefabTiers[tier].members.Length);
            Debug.Log(1);
            e = Instantiate(prefabTiers[tier].members[unit]);
        }
        else
        {
            int unit = UnityEngine.Random.Range(0, prefabBossTiers[tier].members.Length);
            Debug.Log(2);
            e = Instantiate(prefabBossTiers[tier].members[unit]);
        }


        e.row = Mathf.Round(UnityEngine.Random.Range(-3.0f, 4.0f)) - 0.5f;
        e.transform.position = new Vector2(Constants.SCREEN_RIGHT, e.row);
    }
}
