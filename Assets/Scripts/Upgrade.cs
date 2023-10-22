using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public static Upgrade Instance;

    public static int clubDamage {
        get { return clubDamage; }
        set { clubDamage++; }
    }
    public static int clubCooldown {
        get { return clubCooldown; }
        set { clubCooldown++; }
    }

    public static bool melee;
    public static int mDamage
    {
        get { return mDamage; } 
        set { mDamage++; }
    }
    public static int mHealth
    {
        get { return mHealth; } 
        set { mHealth++; }
    }
    public static int mSpeed
    {
        get { return mSpeed; } 
        set { mSpeed++; }
    }
    public static int mCooldown
    {
        get { return mCooldown; } 
        set { mCooldown++; }
    }

    public static bool ranged;
    public static int rDamage
    {
        get { return rDamage; } 
        set { rDamage++; }
    }
    public static int rHealth
    {
        get { return rHealth; } 
        set { rHealth++; }
    }
    public static int rRange
    {
        get { return rRange; } 
        set { rRange++; }
    }
    public static int rCooldown
    {
        get { return rCooldown; } 
        set { rCooldown++; }
    }

    public static bool factory;
    public static int fCooldown
    {
        get { return fCooldown; } 
        set { fCooldown++; }
    }
    public static int fCost
    {
        get { return fCost; } 
        set { fCost++; }
    }

    private void Awake()
    {
        if (Instance)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
