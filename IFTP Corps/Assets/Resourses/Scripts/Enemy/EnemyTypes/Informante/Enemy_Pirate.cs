using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Pirate : Enemy
{
    // Start is called before the first frame update
    void Awake()
    {
        enemyNavMesh = GetComponent<NavMeshAgent>();
        enemyBehaviour = new PirateBehaviour(this, enemyNavMesh);
    }
}
