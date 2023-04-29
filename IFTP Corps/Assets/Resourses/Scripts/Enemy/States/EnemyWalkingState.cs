using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    
    public void EndState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        e.StopDestination();
    }

    public void StartState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        e.unStopDestination();
        e.WalkToDestination();
    }

    public void UpdateState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        if (e.goToPostition != e.enemyNavMesh.destination)
        {
            e.WalkToDestination();
        }

        if (e.CanSpecial())
        {
            eC.ChangeState(eC.attackState);
        }
        if (e.willDie()) 
            e.Die();
       
    }
}
