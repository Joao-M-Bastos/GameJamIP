using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    [SerializeField] GameObject pirate;
    [SerializeField] GameObject informante;

    int roundNumber;

    SpawnBehaviour spawnBehaviour;

    bool hasStarted;

    private void Awake()
    {
        roundNumber = 1;
        hasStarted = false;
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
                spawnBehaviour.GerarRound(pirate, 5, 1f, 0);
                break;
            case 2:
                spawnBehaviour.GerarRound(pirate, 3, 2f,0);
                spawnBehaviour.GerarRound(informante, 3, 2f, 1);
                break;
            case 3:
                spawnBehaviour.GerarRound(pirate, 5, 2f, 0);
                spawnBehaviour.GerarRound(informante, 3, 2f, 1);
                break;

        }
        
    }
}
