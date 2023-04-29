using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EnemyBaseState
{
    public void StartState(EnemyStateControlor eC, EnemyBehaviour e);

    public void UpdateState(EnemyStateControlor eC, EnemyBehaviour e);

    public void EndState(EnemyStateControlor eC, EnemyBehaviour e);
}
