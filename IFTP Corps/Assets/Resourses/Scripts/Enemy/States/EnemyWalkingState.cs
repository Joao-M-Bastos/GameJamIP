using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkingState : EnemyBaseState
{
    Vector3 position;
    public void EndState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        position = Vector3.zero;
    }

    public void StartState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        position = e.goToPostition;
    }

    public void UpdateState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        e.WalkToDestination(position);
    }
}
