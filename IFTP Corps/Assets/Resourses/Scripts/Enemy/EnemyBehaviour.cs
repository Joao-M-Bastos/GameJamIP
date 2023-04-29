using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : EBehaviour
{
    Enemy enemy;

    public Vector3 goToPostition;
    public NavMeshAgent enemyNavMesh;
    
    public EnemyBehaviour(Enemy enemy, NavMeshAgent nv)
    {
        this.enemyNavMesh = nv;
        this.enemy = enemy;
    }

    public void WalkToDestination()
    {
        this.enemyNavMesh.SetDestination(goToPostition);
    }

    public void SetDestination(Vector3 position)
    {
        goToPostition = position;
    }

    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public void Special()
    {
        throw new System.NotImplementedException();
    }

    public bool CanSpecial()
    {
        throw new NotImplementedException();
    }
}
