using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateControlor : MonoBehaviour
{
    public Enemy enemy;

    #region State Machine
    EnemyBaseState currentState;

    public EnemyBaseState attackState = new EnemyAttackState();
    public EnemyBaseState walkState = new EnemyWalkingState();
    #endregion

    private void Awake()
    {
        enemy = this.gameObject.GetComponent<Enemy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(attackState);
    }

    public void ChangeState(EnemyBaseState nextState)
    {
        currentState?.EndState(this, enemy.enemyBehaviour);
        currentState = nextState;
        nextState.StartState(this, enemy.enemyBehaviour);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this, enemy.enemyBehaviour);
    }

    public void SelfDestruction()
    {
        Destroy(this.gameObject);
    }
}
