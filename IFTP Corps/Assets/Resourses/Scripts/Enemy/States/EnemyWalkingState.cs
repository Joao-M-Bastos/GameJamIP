using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    
    public void EndState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        
    }

    public void StartState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        e.WalkToDestination();
    }

    public void UpdateState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        if (e.goToPostition != e.enemyNavMesh.destination)
        {
            e.SetDestination(e.goToPostition);
        }
    }
}
