using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class TowerBehaviour
{
    protected Tower tower;

    

    protected float cooldown;

    GameObject[] allEnemiesInScreen, allEnemiesInRenge;

    public TowerBehaviour(Tower tower)
    {
        this.tower = tower;
    }

    public void LookAtFistEnemy(Transform towerTransform, Transform closestEnemy)
    {
        towerTransform.LookAt(closestEnemy);
    }

    public bool CanAttack()
    {
        if(cooldown > tower.attackCooldown)
        {
            return true;
        }
        else
        {
            cooldown += Time.deltaTime;
            return false;
        }
    }

    public abstract void Attack(Transform transform);

    public GameObject GetCloseEnemies(Transform towerTransform)
    {
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] closeEnemies = null;
        int temp = 0;

        if (allEnemies.Length == 0)
            return null;

        for (int i = 0; i < allEnemies.Length; i++)
        {
            if (Vector3.Distance(towerTransform.position, allEnemies[i].transform.position) < tower.distanceOfView)
            {
                temp++;
            }
        }

        if (temp == 0)
            return null;

        closeEnemies = new GameObject[temp];
        temp = 0; 

        for (int i = 0; i < allEnemies.Length; i++)
        {
            
            if (Vector3.Distance(towerTransform.position, allEnemies[i].transform.position) < tower.distanceOfView)
            {
                closeEnemies[temp] = allEnemies[i];
                temp++;
            }
        }

        

        allEnemiesInScreen = allEnemies;
        allEnemiesInRenge = closeEnemies;
        return GetClosestEnemy(closeEnemies);
    }

    public GameObject GetClosestEnemy(GameObject[] closeEnemies)
    {
        float closestDistance = float.MaxValue;
        GameObject closestEnemy = null;

        

        for (int i = 0; i < closeEnemies.Length; i++)
        {

                float distance = closeEnemies[i].transform.position.y - tower.finalPoint.position.y;

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestEnemy = closeEnemies[i];
                }


        }
        return closestEnemy;
    }

    public void Clean()
    {
        tower.SelfDestruction();
    }
}
