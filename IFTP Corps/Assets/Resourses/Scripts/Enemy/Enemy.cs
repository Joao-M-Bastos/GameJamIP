using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyBehaviour enemyBehaviour;

    public float speed;

    // Start is called before the first frame update
    void Awake()
    {
        enemyBehaviour = new EnemyBehaviour(this);
    }
}
