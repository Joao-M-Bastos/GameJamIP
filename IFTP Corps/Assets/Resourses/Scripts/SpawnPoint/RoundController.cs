using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    [SerializeField] Dictionary<String, GameObject> enemies;

    [SerializeField] GameObject playButton;

    int roundNumber;

    SpawnBehaviour spawnBehaviour;

    [SerializeField] bool hasStarted;

    private void Awake()
    {
        roundNumber = 0;
        hasStarted = false;
        spawnBehaviour = GetComponent<SpawnBehaviour>();
    }

    private void Update()
    {
        if(!hasStarted && spawnBehaviour.amountToSpawn > 0)
        {
            HandleEndRound(true);
        }

        if (hasStarted && spawnBehaviour.amountToSpawn < 1 && NumOfEnemiesAlive.getNumOfEnemiesAlive() < 1)
        {
            
            HandleEndRound(false);
            if (roundNumber == 5)
                GMScript.GameOver(true);
        }        
    }

    public void HandleEndRound(bool b)
    {
        hasStarted = b;
        playButton.SetActive(!b);
    }

    public void OnPlayClick()
    {
        GenerateRound();
    }

    private void Start()
    {
        enemies = EnemyTowerDictionary.GetDicionaryDeInimigos();
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
                spawnBehaviour.GerarRound(enemies["Leaker"], 3, 2f, 1);
                break;
            case 3:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 5, 2f, 1);
                break;
            case 4:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 5, 2f, 1);
                break;
            case 5:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 5, 2f, 1);
                break;
            

        }
        
    }
}
