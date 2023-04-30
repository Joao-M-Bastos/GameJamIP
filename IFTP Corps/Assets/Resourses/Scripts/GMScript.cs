using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    [SerializeField] private static int life;
    [SerializeField] private static int money;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GlobalScript.GoToScene("",0) ;
    }

    private void Awake()
    {
        ResetMoney();

        ResetLife();
    }

    #region Life

    public void ResetLife()
    {
        life = 3;
    }

    public int getLife()
    {
        return life;
    }

    public void playerTakeADamage()
    {
        life--;
    }
    #endregion

    #region Money

    public void ResetMoney()
    {
        money = 100;
    }

    public int getMoney()
    {
        Debug.Log(money);
        return money;
    }

    public void playerSpendMoney(int value)
    {
        money -= value;
    }

    public void playerGainMoney(int value)
    {
        money += value;
    }
    #endregion
}
