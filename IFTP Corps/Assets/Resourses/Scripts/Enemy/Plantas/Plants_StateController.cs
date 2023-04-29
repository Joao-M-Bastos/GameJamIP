using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants_StateController : MonoBehaviour
{
    public PlantsScript plantsScript;

    #region State Machine
    Plants_BaseState currentState;

    public Plants_StartState startState = new Plants_StartState();
    public Plants_MidState midState = new Plants_MidState();
    public Plants_FullState fullState = new Plants_FullState();
    #endregion

    private void Awake()
    {
        plantsScript = this.gameObject.GetComponent<PlantsScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(startState);
    }

    public void ChangeState(Plants_BaseState nextState)
    {
        currentState?.EndState(this, plantsScript.plantsBehaviour);
        currentState = nextState;
        nextState.StartState(this, plantsScript.plantsBehaviour);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this, plantsScript.plantsBehaviour);
    }

    public void SelfDestruction()
    {
        Destroy(this.gameObject);
    }
}
