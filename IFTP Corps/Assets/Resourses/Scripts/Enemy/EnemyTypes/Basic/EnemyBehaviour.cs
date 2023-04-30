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
        this.enemyNavMesh.isStopped = true;
    }
    public void HasMadeIt()
    {
        enemy.gmInstance.playerTakeADamage();
        enemy.SelfDestruction();
    }

    public void Die()
    {
        enemy.gmInstance.playerGainMoney(enemy.bounty);

        if (enemy.isReturning)
            enemy.gmInstance.OneLessSteal();

        enemy.SelfDestruction();
    }
    public bool willDie()
    {
        if (enemy.life < 1)
            return true;

        return false;
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

    public void FlipDirection(bool b)
    {
        enemy.isReturning = b;
        if (b)
            enemy.gmInstance.OneMoreSteal();
    }

    public void ChangeSpeed(float value)
    {
        this.enemy.speed = value;

    }

    public void takeAHit(int dmg = 1)
    {
        if(!enemy.indestrutive)
            enemy.life -= dmg;
    }
}
