using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tower : MonoBehaviour
{
    [SerializeField] public TowerBehaviour towerBehaviour;
    [SerializeField] public GameObject projectile, areaView;

    [SerializeField] public Transform finalPoint;

    [SerializeField] public float attackCooldown, projectSpeed;

    [SerializeField] public int distanceOfView, damage, price;


    // Start is called before the first frame update
    void Awake()
    {
        finalPoint = GameObject.FindGameObjectWithTag("IP").transform;
        //towerBehaviour = new TowerBehaviour(this);
    }

    public void CreateAreaView(bool b)
    {
        this.areaView.SetActive(b);

        if (!b)
            return;

        areaView.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        areaView.transform.localScale *= distanceOfView / 2.5f;
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
