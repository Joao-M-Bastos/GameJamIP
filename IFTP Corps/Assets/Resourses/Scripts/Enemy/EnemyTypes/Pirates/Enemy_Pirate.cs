using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Pirate : Enemy
{
    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        isReturning = true;
        enemyBehaviour = new PirateBehaviour(this, navMeshAgent);
    }
}
