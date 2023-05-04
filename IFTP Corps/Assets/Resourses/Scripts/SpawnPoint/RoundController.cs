using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    [SerializeField] Dictionary<String, GameObject> enemies;

    [SerializeField] GameObject playButton;

    public int roundNumber;

    SpawnBehaviour spawnBehaviour;

     bool hasStarted;

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
            if (roundNumber == 6)
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
                //spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 2, 2f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 2, 2f, 10);
                spawnBehaviour.GerarRound(enemies["Leaker"], 2, 2f, 24);
                break;
            case 2:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 1f,0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 4, 2f, 5);
                spawnBehaviour.GerarRound(enemies["Leaker"], 3, 1f, 21);
                break;
            case 3:
                spawnBehaviour.GerarRound(enemies["Pirata"], 5, 2f, 5);
                spawnBehaviour.GerarRound(enemies["Leaker"], 8, 2f, 0);
                spawnBehaviour.GerarRound(enemies["Pirata"], 3, 4f, 16);
                spawnBehaviour.GerarRound(enemies["Leaker"], 8, 1f, 45);
                break;
            case 4:
                spawnBehaviour.GerarRound(enemies["Pirata"], 6, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 10, 2f, 1);
                break;
            case 5:
                spawnBehaviour.GerarRound(enemies["Pirata"], 9, 1f, 0);
                spawnBehaviour.GerarRound(enemies["Leaker"], 12, 2f, 1);
                break;
            

        }
        

    }
}
