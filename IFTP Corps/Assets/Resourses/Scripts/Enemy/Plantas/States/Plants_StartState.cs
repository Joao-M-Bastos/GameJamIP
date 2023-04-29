using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants_StartState : Plants_BaseState
{
    public void StartState(Plants_StateController pC, PlantsBehaviour p)
    {
        p.setTimer(3);
        p.RenderPlant(0);
    }

    public void UpdateState(Plants_StateController pC, PlantsBehaviour p)
    {
        if(p.hasWait())
        {
            pC.ChangeState(pC.midState);
        }
        
    }

    public void EndState(Plants_StateController pC, PlantsBehaviour p)
    {
        
    }
}
