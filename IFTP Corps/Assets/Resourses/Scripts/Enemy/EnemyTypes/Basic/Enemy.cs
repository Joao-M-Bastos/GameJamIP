using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public EnemyBehaviour enemyBehaviour;
    public NavMeshAgent enemyNavMesh;
    public GMScript gmInstance;

    public float baseSpeed;
    public float speed;

    public int life, bounty;

    public bool isReturning, invisiable, indestrutive;

    // Start is called before the first frame update
    void Awake()
    {
        GetIsntances();
        //enemyBehaviour = new EnemyBehaviour(this, enemyNavMesh);
    }

    public void GetIsntances()
    {
        gmInstance = GameObject.FindGameObjectWithTag("GameController").GetComponent<GMScript>();

        enemyNavMesh = GetComponent<NavMeshAgent>();

        speed = baseSpeed;
    }



    public void SelfDestruction()
    {
        NumOfEnemiesAlive.Subtract();
        Destroy(this.gameObject);
    }
}
