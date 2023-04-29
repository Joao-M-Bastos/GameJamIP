using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointA : MonoBehaviour
{
    Enemy enemy;
    CaminhoScript caminhoScript;

    private void Awake()
    {
        caminhoScript = GameObject.Find("Points").GetComponent<CaminhoScript>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out enemy))
        {
            caminhoScript.GotOnPointsInicial(enemy);
        }
    }
}
