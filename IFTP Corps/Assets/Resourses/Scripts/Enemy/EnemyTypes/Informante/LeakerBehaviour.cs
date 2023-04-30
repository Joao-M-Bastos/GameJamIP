using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LeakerBehaviour : EnemyBehaviour
{

    public LeakerBehaviour(Enemy enemy, NavMeshAgent nv) : base(enemy, nv)
    {
        this.enemyNavMesh = nv;
        this.enemy = enemy;

        enemyNavMesh.speed = enemy.speed;
    }

    public override void Special()
    {
        this.HasMadeIt();

        hasEndedSpecial = true;
    }

    public override bool CanSpecial()
    {
        if (enemy.isReturning)
        {
            return true;
        }

        return false;
    }
}
