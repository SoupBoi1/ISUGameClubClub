using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public static Upgrade Instance;

    public static int clubDamage = 0;
    public static int clubCooldown= 0;

    public static bool melee = true;
    public static int mDamage = 0;
    public static int mHealth = 0;
    public static int armor = 0;
    public static int mCooldown = 0;

    public static bool ranged = true;
    public static int rDamage = 0;
    public static int rRange= 0;
    public static int speed = 0;
    public static int rCooldown = 0;

    public static bool factory = true;
    public static int fCooldown = 0;
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
