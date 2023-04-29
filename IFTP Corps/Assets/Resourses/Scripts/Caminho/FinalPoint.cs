using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPoint : MonoBehaviour
{
    [SerializeField] CaminhoScript caminhoScript;

    private void OnTriggerEnter(Collider collision)
    {
        Enemy enemy;
        if (collision.gameObject.TryGetComponent<Enemy>(out enemy))
        {
            caminhoScript.GotOnPointsFinal(enemy);
        }
    }
}
