using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PirateBehaviour : EnemyBehaviour
{

    public PirateBehaviour(Enemy enemy, NavMeshAgent nv) : base(enemy, nv)
    {
        this.enemyNavMesh = nv;
        this.enemy = enemy;

        enemyNavMesh.speed = enemy.speed;
    }

    public override void Special()
    {
        if (enemy.isReturning) {
            enemy.invisiable = false;
        }

        if (!enemy.isReturning)
        {
            enemy.invisiable = true;
        }   

        hasEndedSpecial = true;
    }

    public override bool CanSpecial()
    {
        if (enemy.isReturning == enemy.invisiable)
        {
            return true;
        }

        return false;
    }
}
