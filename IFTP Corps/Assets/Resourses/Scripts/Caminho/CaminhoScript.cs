using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminhoScript : MonoBehaviour
{

    GMScript gameManager;

    [SerializeField]Transform transformA, transformB;

    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GMScript>();
    }

    public void GotOnPointsInicial(Enemy enemy)
    {

        if(enemy.isReturning)
        {
            gameManager.playerTakeADamage();
            enemy.enemyBehaviour.HasMadeIt();

            Debug.Log(gameManager.getLife());
        }

        enemy.isReturning = false;

        

        enemy.enemyBehaviour.SetDestination(transformB.position);
    }


    public void GotOnPointsFinal(Enemy enemy)
    {
        enemy.isReturning = true;

        enemy.enemyBehaviour.SetDestination(transformA.position);
    }
}
