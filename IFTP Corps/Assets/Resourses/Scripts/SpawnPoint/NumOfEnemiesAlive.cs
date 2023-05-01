using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NumOfEnemiesAlive
{
    [SerializeField] static private int numOfEnemiesAlive;

    public static void Add(int i = 1)
    {
        numOfEnemiesAlive += i;
    }

    public static void Subtract(int i = 1)
    {
        numOfEnemiesAlive -= i;
    }

    public static void Zero() 
    {
        numOfEnemiesAlive = 0;
    }

    public static int getNumOfEnemiesAlive()
    {
        return numOfEnemiesAlive;
    }
}
