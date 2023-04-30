using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    [SerializeField] Dictionary<String, GameObject> enemies;

    int roundNumber;

    SpawnBehaviour spawnBehaviour;

    bool hasStarted;

    private void Awake()
    {
        roundNumber = 0;
        hasStarted = false;
        enemies = EnemyTowerDictionary.GetDicionaryDeInimigos();
        spawnBehaviour = GetComponent<SpawnBehaviour>();
    }

    private void Update()
    {
        if(!hasStarted && spawnBehaviour.amountToSpawn > 0)
            hasStarted = true;
        
        if(hasStarted && spawnBehaviour.amountToSpawn < 1 && NumOfEnemiesAlive.getNumOfEnemiesAlive() < 1)
        {
            GenerateRound();
            hasStarted = false;
        }
    }

    private void Start()
    {
        GenerateRound();
    }

    private void GenerateRound()
    {
        roundNumber++;
        switch (roundNumber)
        {
            case 1:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f, 0);
                break;
            case 2:
                spawnBehaviour.GerarRound(enemies["Pirata"], 3, 2f,0);
                spawnBehaviour.GerarRound(enemies["Informante"], 3, 2f, 1);
                break;
            case 3:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Informante"], 5, 2f, 1);
                break;

        }
        
    }
}
