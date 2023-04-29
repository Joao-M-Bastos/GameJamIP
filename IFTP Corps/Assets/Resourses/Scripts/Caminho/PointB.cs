using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointB : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] CaminhoScript caminhoScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out enemy))
        {
            caminhoScript.GetFromPointB(enemy, this.transform.position);
        }
    }
}
