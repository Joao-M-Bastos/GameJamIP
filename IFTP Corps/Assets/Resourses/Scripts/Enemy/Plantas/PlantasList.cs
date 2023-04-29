using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantasList : MonoBehaviour
{
    [SerializeField] private GameObject[] plantsObjects;

    public static Dictionary<string, GameObject> listOfAllPlants = new Dictionary<string, GameObject>();


    private void Awake()
    {
        foreach (GameObject p in plantsObjects)
        {
            listOfAllPlants.Add(p.name, p);
        }
    }
}