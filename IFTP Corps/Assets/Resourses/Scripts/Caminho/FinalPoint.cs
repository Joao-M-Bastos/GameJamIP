using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPoint : MonoBehaviour
{
    
    [SerializeField] CaminhoScript caminhoScript;

    private void Awake()
    {
        caminhoScript = GameObject.Find("Points").GetComponent<CaminhoScript>();

    }

    private void OnTriggerEnter(Collider collision)
    {
        Enemy enemy;
        if (collision.gameObject.TryGetComponent<Enemy>(out enemy))
        {
            caminhoScript.GotOnPointsFinal(enemy);
        }

        PointA pointA;
        if (collision.gameObject.TryGetComponent<PointA>(out pointA))
        {
            Destroy(this.gameObject);
            caminhoScript.reespawnIP();
        }
    }
}
