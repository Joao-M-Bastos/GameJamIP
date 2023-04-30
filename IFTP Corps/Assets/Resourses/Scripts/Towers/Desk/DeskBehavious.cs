using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskBehavious : MonoBehaviour
{
    [SerializeField] private Transform pointToSpawn;

    [SerializeField] private Dictionary<string, GameObject> listaDeTorres;

    GMScript gmInstance;

    private void Start()
    {
        gmInstance = GameObject.FindGameObjectWithTag("GameController").GetComponent<GMScript>();

        listaDeTorres = EnemyTowerDictionary.GetDicionaryDeTorres();    
    }

    public void SelectDesc()
    {
        if (gmInstance.getMoney() >= 100)
            Instantiate(listaDeTorres["Advogado"], pointToSpawn);
        else
            Debug.Log("a");
        
    }
}
