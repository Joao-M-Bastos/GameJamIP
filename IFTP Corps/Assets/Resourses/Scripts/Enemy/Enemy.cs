using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public EnemyBehaviour enemyBehaviour;
    NavMeshAgent enemyNavMesh;

    public float speed;

    public bool isReturning;

    // Start is called before the first frame update
    void Awake()
    {
        enemyNavMesh = GetComponent<NavMeshAgent>();
        isReturning = false;
        enemyBehaviour = new EnemyBehaviour(this, enemyNavMesh);
    }
}
