using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletScript : MonoBehaviour
{
    protected Transform target;
    protected int dmg;
    protected float speed;

    public void SetValues(Transform target, int damage, float speed)
    {
        this.target = target;
        this.dmg = damage;
        this.speed = speed;
    }

    private void Update()
    {
        if (target != null)
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

    public IEnumerator DestroyBullet(float cooldown)
    { 
        yield return new WaitForSeconds(cooldown);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider colision)
    {
        Enemy go;
        if (colision.gameObject.TryGetComponent<Enemy>(out go))
        {
            if (go.invisiable)
                return;

            go.enemyBehaviour.takeAHit(dmg);
            Destroy(this.gameObject);
        }
    }
}
