using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tower : MonoBehaviour
{
    [SerializeField] public TowerBehaviour towerBehaviour;
    [SerializeField] public GameObject projectile, areaView;

    [SerializeField] public Transform finalPoint, shotPoint;

    [SerializeField] public float attackCooldown, projectSpeed;

    [SerializeField] public int distanceOfView, damage, price;

    [SerializeField] public Animator towerAnim;


    // Start is called before the first frame update
    void Awake()
    {
        towerAnim = GetComponent<Animator>();
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
        GameObject project = Instantiate(projectile,shotPoint.position, transform.rotation);
        project.GetComponent<BasicBulletScript>().SetValues(transform, damage, projectSpeed);
    }
}
