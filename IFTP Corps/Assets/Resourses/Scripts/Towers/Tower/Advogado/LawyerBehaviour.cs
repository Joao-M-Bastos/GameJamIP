using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LawyerBehaviour : TowerBehaviour
{
    GameObject[] allTowersInScreen, allTowersInRenge;

    public LawyerBehaviour(Tower tower):base(tower)
    {
        this.tower = tower;
    }

    public override void Attack(Transform transform)
    {
        tower.InstancieteProjectile(transform);
        cooldown = 0;
    }
}
