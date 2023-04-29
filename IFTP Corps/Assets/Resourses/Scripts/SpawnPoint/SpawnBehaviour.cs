using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    [SerializeField] GameObject pirate;

    private void Awake()
    {
        GerarRound(pirate, 5,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GerarRound(GameObject enemy, int amont, float cooldown)
    {
        StartCoroutine(Spawnar(enemy, amont, cooldown));
    }

    private IEnumerator Spawnar(GameObject enemy, int amont, float cooldown)
    {
        
        for(int i = 0; i < amont; i++)
        {
            yield return new WaitForSeconds(cooldown);
            Instantiate(enemy);
        }
    }


}
