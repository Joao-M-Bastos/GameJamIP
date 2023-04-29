using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : EnemyBaseState
{
    public void EndState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        
    }

    public void StartState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        e.Special();
    }

    public void UpdateState(EnemyStateControlor eC, EnemyBehaviour e)
    {
        if (e.HasEndedSpecial())
        {
            eC.ChangeState(eC.walkState);
        }
        else
        {
            e.Special();
        }
    }
}
