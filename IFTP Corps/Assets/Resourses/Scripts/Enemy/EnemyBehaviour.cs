using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : EBehaviour
{
    Enemy enemy;

    public Vector3 goToPostition;
    
    public EnemyBehaviour(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void WalkToDestination(Vector3 position)
    {
        enemy.transform.LookAt(position, enemy.transform.up);
        MoveFoward();
    }

    private void MoveFoward()
    {
        enemy.transform.position += enemy.transform.forward * enemy.speed * Time.deltaTime;
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
