using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants_MidState : Plants_BaseState
{
    public void StartState(Plants_StateController pC, PlantsBehaviour p)
    {
        p.setTimer(3);
        p.RenderPlant(1);
    }

    public void UpdateState(Plants_StateController pC, PlantsBehaviour p)
    {
        if (p.hasWait())
            pC.ChangeState(pC.fullState);
        
    }

    public void EndState(Plants_StateController pC, PlantsBehaviour p)
    {
        
    }
}
