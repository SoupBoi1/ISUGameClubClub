using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public static Upgrade Instance;

    public static int ClubDamage
    {
        get { return clubDamage; }
        set { clubDamage++; }
    }
    private static int clubDamage = 0;
    public static int ClubCooldown {
        get { return clubCooldown; }
        set { clubCooldown++; }
    }
    public static int clubCooldown= 0;

    public static bool melee;
    public static int MDamage
    {
        get { return mDamage; } 
        set { mDamage++; }
    }
    public static int mDamage = 0;
    public static int MHealth
    {
        get { return mHealth; } 
        set { mHealth++; }
    }
    public static int mHealth= 0;
    public static int MSpeed
    {
        get { return mSpeed; } 
        set { mSpeed++; }
    }
    public static int mSpeed= 0;
    public static int MCooldown
    {
        get { return mCooldown; } 
        set { mCooldown++; }
    }
    public static int mCooldown = 0;

    public static bool ranged;
    public static int RDamage
    {
        get { return rDamage; } 
        set { rDamage++; }
    }
    public static int rDamage = 0;
    public static int RHealth
    {
        get { return rHealth; } 
        set { rHealth++; }
    }
    public static int rHealth = 0;
    public static int RRange
    {
        get { return rRange; } 
        set { rRange++; }
    }
    public static int rRange= 0;
    public static int RCooldown
    {
        get { return rCooldown; } 
        set { rCooldown++; }
    }
    public static int rCooldown = 0;

    public static bool factory;
    public static int FCooldown
    {
        get { return fCooldown; } 
        set { fCooldown++; }
    }
    public static int fCooldown = 0;
    public static int FCost
    {
        get { return fCost; } 
        set { fCost++; }
    }
    public static int fCost = 0;

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
