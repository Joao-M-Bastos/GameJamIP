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
        cooldown = tower.attackCooldown;
    }

    public void LookAtFistEnemy(Transform towerTransform, Transform closestEnemy)
    {
        Vector3 lookaAt = closestEnemy.position;
        lookaAt.y = 0;
        towerTransform.LookAt(lookaAt);
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
                if(!allEnemies[i].GetComponent<Enemy>().invisiable)
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
                if (!allEnemies[i].GetComponent<Enemy>().invisiable)
                {
                    closeEnemies[temp] = allEnemies[i];
                    temp++;
                }
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


            float distance = closeEnemies[i].transform.position.z - tower.finalPoint.position.z;

            if (closeEnemies[i].GetComponent<Enemy>().isReturning)
                distance *= -1;

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
