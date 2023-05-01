using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskBehavious : MonoBehaviour
{
    [SerializeField] private Transform pointToSpawn;

    private GameObject currentTower;



    public void PlaceTower(GameObject torre, GMScript gmInstance)
    {
        if (currentTower == null && gmInstance.getMoney() >= 50)
        {
            currentTower = Instantiate(torre, pointToSpawn);
            gmInstance.playerSpendMoney(currentTower.GetComponent<Tower>().price);
            SelectTower(true);
        }
    }

    public void SelectTower(bool b)
    {
        
        if (currentTower != null)
        {
            currentTower.GetComponent<Tower>().CreateAreaView(b);
        }
    }
}
