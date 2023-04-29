using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TowerUpdate : MonoBehaviour
{
    public Tower tower;
    
    GameObject closestEnemy;

    private void Awake()
    {
        tower = gameObject.GetComponent<Tower>();
    }

    private void Update()
    {
        closestEnemy = tower.towerBehaviour.GetCloseEnemies(this.transform);

        if (closestEnemy != null)
        {
            tower.towerBehaviour.LookAtFistEnemy(this.transform, closestEnemy.transform);
        }
        if (tower.towerBehaviour.CanAttack() && closestEnemy != null)
        {
            tower.towerBehaviour.Attack(closestEnemy.transform);
        }
    }


}