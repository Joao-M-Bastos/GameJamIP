using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointA : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] CaminhoScript caminhoScript;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out enemy))
        {
            caminhoScript.GetFromPointA(enemy);
        }
    }
}
