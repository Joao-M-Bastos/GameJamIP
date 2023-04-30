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
            this.transform.position += transform.forward * speed *Time.deltaTime;
        }
        if (target == null)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider colision)
    {
        Enemy go;
        if (colision.gameObject.TryGetComponent<Enemy>(out go))
        {
            go.enemyBehaviour.takeAHit(dmg);
            Destroy(this.gameObject);
        }
    }
}
