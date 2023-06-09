using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LawyerBulletScript : BasicBulletScript
{

    private void Update()
    {
        if(target != null)
        {
            this.transform.LookAt(target);
            this.transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (target == null)
        {
            StartCoroutine(DestroyBullet(5));
            this.transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
