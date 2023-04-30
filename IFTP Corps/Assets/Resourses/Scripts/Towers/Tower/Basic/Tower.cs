using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tower : MonoBehaviour
{
    public TowerBehaviour towerBehaviour;
    public GameObject projectile, areaView;

    public Transform finalPoint;

    public float attackCooldown, projectSpeed;

    public int distanceOfView, damage;

    // Start is called before the first frame update
    void Awake()
    {
        finalPoint = GameObject.FindGameObjectWithTag("IP").transform;
        CreateAreaView();
        //towerBehaviour = new TowerBehaviour(this);
    }

    public void CreateAreaView()
    {
        areaView.transform.localScale *= distanceOfView /2.5f;
    }

    public void SelfDestruction()
    {
        Destroy(this.gameObject);
    }

    public void InstancieteProjectile(Transform transform)
    {
        GameObject project = Instantiate(projectile,this.transform.position, transform.rotation);
        project.GetComponent<BasicBulletScript>().SetValues(transform, damage, projectSpeed);
    }
}
