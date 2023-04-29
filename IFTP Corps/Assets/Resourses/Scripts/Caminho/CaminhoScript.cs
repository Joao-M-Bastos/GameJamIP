using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminhoScript : MonoBehaviour
{
    [SerializeField]Transform transformA, transformB;
    public void GotOnPoints(Enemy enemy)
    {
        enemy.isReturning = !enemy.isReturning;

        if (!enemy.isReturning)
        {
            enemy.enemyBehaviour.SetDestination(transformB.position);
        }
        else
        {
            enemy.enemyBehaviour.SetDestination(transformA.position);
        }

    }
}
