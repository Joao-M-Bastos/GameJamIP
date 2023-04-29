using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminhoScript : MonoBehaviour
{
    [SerializeField]Transform transformA, transformB;

    private void Awake()
    {
        
    }
    public void GotOnPointsInicial(Enemy enemy)
    {
        enemy.isReturning = false;

        enemy.enemyBehaviour.SetDestination(transformB.position);
    }


    public void GotOnPointsFinal(Enemy enemy)
    {
        enemy.isReturning = true;

        enemy.enemyBehaviour.SetDestination(transformA.position);
    }
}
