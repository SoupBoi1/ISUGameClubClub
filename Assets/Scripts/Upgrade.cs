using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public static Upgrade Instance;

    public static bool firstTime = true;

    public static int clubDamage = 0;
    public static int clubCooldown= 0;

    public static int health = 0;

    public static int mDamage = 0;
    public static int rDamage = 0;
    public static int speed = 0;
    public static int cooldown = 0;

    public static int fCooldown = 0;
    public static int price = 0;

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
