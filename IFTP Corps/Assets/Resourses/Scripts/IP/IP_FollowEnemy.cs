using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IP_FollowEnemy : MonoBehaviour
{
    Enemy enemy;

    Transform transformToFollow;

    private void OnTriggerStay(Collider collision)
    {
        if (transformToFollow == null && collision.gameObject.TryGetComponent<Enemy>(out enemy))
                this.transformToFollow = enemy.transform;
        
    }

    void Update()
    {
        if(transformToFollow != null)
            Follow();
    }

    private void Follow()
    {
        this.transform.position = transformToFollow.position + (Vector3.up * 3);
    }
}
