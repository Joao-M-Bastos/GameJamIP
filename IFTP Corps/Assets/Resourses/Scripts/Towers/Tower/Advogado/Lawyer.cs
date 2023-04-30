using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Lawyer : Tower
{
    // Start is called before the first frame update
    void Awake()
    {
        finalPoint = GameObject.FindGameObjectWithTag("IP").transform;
        towerBehaviour = new LawyerBehaviour(this);
    }
}
