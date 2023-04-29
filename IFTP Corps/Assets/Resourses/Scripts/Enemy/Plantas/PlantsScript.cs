using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsScript : MonoBehaviour
{
    public PlantsBehaviour plantsBehaviour;

    public GameObject[] plantsRender;

    // Start is called before the first frame update
    void Awake()
    {
        plantsBehaviour = new PlantsBehaviour(plantsRender);
    }
}
