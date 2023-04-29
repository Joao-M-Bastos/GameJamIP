using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants_FullState : Plants_BaseState
{
    public void StartState(Plants_StateController pC, PlantsBehaviour p)
    {
        p.setTimer(3);
        p.RenderPlant(2);
    }

    public void UpdateState(Plants_StateController pC, PlantsBehaviour p)
    {
        if (p.hasWait())
            EndState(pC, p);
            //pC.ChangeState(pC.startState);
    }

    public void EndState(Plants_StateController pC, PlantsBehaviour p)
    {
        pC.SelfDestruction();
    }
}
