using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBehaviour
{
    protected Enemy enemy;

    public Vector3 goToPostition;
    public NavMeshAgent enemyNavMesh;
    protected bool hasEndedSpecial;
    
    public EnemyBehaviour(Enemy enemy, NavMeshAgent nv)
    {
        this.enemyNavMesh = nv;
        this.enemy = enemy;

        enemyNavMesh.speed = enemy.speed;
    }

    public void WalkToDestination()
    {
        this.enemyNavMesh.SetDestination(goToPostition);
    }

    public void SetDestination(Vector3 position)
    {
        goToPostition = position;
    }

    public void unStopDestination()
    {
        this.enemyNavMesh.isStopped = false;
    }

    public void StopDestination()
    {
        Debug.Log("a");
        this.enemyNavMesh.isStopped = true;
    }

    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public abstract void Special();

    public abstract bool CanSpecial();

    public bool HasEndedSpecial()
    {
        if (hasEndedSpecial)
        {
            hasEndedSpecial = false;
            return true;
        }
        return false;
    }

    public void FlipDirection()
    {
        enemy.isReturning = !enemy.isReturning;
    }
}
