using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsBehaviour : PBehaviour
{
    private GameObject[] plantsRender;

    private float countDown;

    public PlantsBehaviour(GameObject[] plantsRender)
    {
        this.plantsRender = plantsRender;
    }

    public void setTimer(float cooldown)
    {
        countDown = cooldown;
    }

    public bool hasWait()
    {            
        if (countDown <= 0)
            return true;
        


        countDown -= Time.deltaTime;
        return false;

    }

    public void RenderPlant(int plantIndex)
    {
        foreach (GameObject g in plantsRender)
        {
            g.SetActive(false);
            if (g == this.plantsRender[plantIndex])
                g.SetActive(true);
        }
    }
}
