using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public EnemyBehaviour enemyBehaviour;
    public NavMeshAgent enemyNavMesh;

    public float speed;

    public int life;

    public bool isReturning, invisiable, indestrutive;

    // Start is called before the first frame update
    void Awake()
    {
        enemyNavMesh = GetComponent<NavMeshAgent>();
        isReturning = false;
        //enemyBehaviour = new EnemyBehaviour(this, enemyNavMesh);
    }

    public void SelfDestruction()
    {
        Destroy(this.gameObject);
    }
}
