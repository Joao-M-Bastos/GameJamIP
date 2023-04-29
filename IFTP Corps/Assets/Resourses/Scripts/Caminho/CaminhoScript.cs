using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminhoScript : MonoBehaviour
{
    public void GetFromPointA(Enemy enemy, Vector3 position)
    {
        if (!enemy.isReturning)
        {
            enemy.enemyBehaviour.SetDestination(position);
        }
    }

    public void GetFromPointB(Enemy enemy, Vector3 position)
    {
        if (!enemy.isReturning)
        {
            enemy.enemyBehaviour.SetDestination(position);
        }
    }
}
