using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointB : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] CaminhoScript caminhoScript;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out enemy))
        {
            caminhoScript.GetFromPointB(enemy);
        }
    }
}
