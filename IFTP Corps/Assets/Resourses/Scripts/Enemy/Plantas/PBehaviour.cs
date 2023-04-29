using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PBehaviour
{
    public void setTimer(float cooldown);

    public bool hasWait();

    public void RenderPlant(int plantIndex);

}
