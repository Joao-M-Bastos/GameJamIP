using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Plants_BaseState
{
    public void StartState(Plants_StateController pC, PlantsBehaviour p);

    public void UpdateState(Plants_StateController pC, PlantsBehaviour p);

    public void EndState(Plants_StateController pC, PlantsBehaviour p);
}
