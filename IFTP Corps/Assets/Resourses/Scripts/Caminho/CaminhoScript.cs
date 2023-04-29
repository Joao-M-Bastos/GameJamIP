using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminhoScript : MonoBehaviour
{
    [SerializeField]Transform transformA, transformB;
    public void GetFromPointA(Enemy enemy)
    {
        if (!enemy.isReturning)
        {
            enemy.enemyBehaviour.SetDestination(transformB.position);
        }
    }

    public void GetFromPointB(Enemy enemy)
    {
        if (enemy.isReturning)
        {
            Debug.Log("AS");
            enemy.enemyBehaviour.SetDestination(transformA.position);
        }
    }
}
