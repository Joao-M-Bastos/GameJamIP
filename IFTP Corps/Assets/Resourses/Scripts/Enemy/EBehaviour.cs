using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EBehaviour
{
    public void SetDestination(Vector3 position);

    public void WalkToDestination(Vector3 position);

    public bool CanSpecial();

    public void Special();

    public void Die();
}
