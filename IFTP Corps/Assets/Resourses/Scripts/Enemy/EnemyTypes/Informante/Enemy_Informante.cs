using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Informante : Enemy
{
    // Start is called before the first frame update
    void Awake()
    {
        GetIsntances();
        enemyBehaviour = new InformanteBehaviour(this, enemyNavMesh);
    }
}
