using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskBehavious : MonoBehaviour
{
    [SerializeField] private Transform pointToSpawn;

    [SerializeField] private Dictionary<string, GameObject> listaDeTorres;

    private GameObject currentTower;

    GMScript gmInstance;

    private void Start()
    {
        gmInstance = GameObject.FindGameObjectWithTag("GameController").GetComponent<GMScript>();

        listaDeTorres = EnemyTowerDictionary.GetDicionaryDeTorres();    
    }

    public void SelectDesc()
    {
        if (currentTower == null && gmInstance.getMoney() >= 100)
        {

            currentTower = Instantiate(listaDeTorres["Advogado"], pointToSpawn);
            gmInstance.playerSpendMoney(currentTower.GetComponent<Tower>().price);
            Debug.Log(currentTower.GetComponent<Tower>().price);
            gmInstance.getMoney();
        }
        else
            Debug.Log("a");
        
    }
}
