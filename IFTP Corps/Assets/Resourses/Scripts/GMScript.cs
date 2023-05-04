using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GMScript : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int money;

    [SerializeField] private GameObject[] lifeIcons;


    [SerializeField] private GameObject stealingIcon;
    [SerializeField] private int stealingNum;

    [SerializeField] public RoundController rd;

    [SerializeField] private Text moneyText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GlobalScript.GoToScene("",0) ;

        OPButtons();
    }

    private void OPButtons()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            rd.roundNumber = 0;

        if (Input.GetKeyDown(KeyCode.Alpha2))
            rd.roundNumber = 1;

        if (Input.GetKeyDown(KeyCode.Alpha3))
            rd.roundNumber = 2;

        if (Input.GetKeyDown(KeyCode.Alpha4))
            rd.roundNumber = 3;

        if (Input.GetKeyDown(KeyCode.Alpha5))
            rd.roundNumber = 4;

        if (Input.GetKeyDown(KeyCode.H))
            ResetLife();

        if (Input.GetKeyDown(KeyCode.M))
            playerGainMoney(100);

        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            foreach(GameObject g in enemies)
            {
                g.GetComponent<Enemy>().life = 0;
            }
        }
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
        ShowLifeIcons();
    }

    public int getLife()
    {
        return life;
    }

    public void playerTakeADamage()
    {
        life--;
        ShowLifeIcons();
    }

    public void ShowLifeIcons()
    {
        if(life == 0)
        {
            GameOver(false);
            return;
        }
        for(int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].SetActive(false);

            if(i < getLife())
                lifeIcons[i].SetActive(true);
        }
    }
    #endregion

    #region Money

    public void ResetMoney()
    {
        money = 100;
        UpdadeMoneyValue();
    }

    public int getMoney()
    {
        return money;
    }

    public void playerSpendMoney(int value)
    {
        money -= value;
        UpdadeMoneyValue();
    }

    public void playerGainMoney(int value)
    {
        money += value;
        UpdadeMoneyValue();
    }

    public void UpdadeMoneyValue()
    {
        moneyText.text = getMoney() + " ";
    }

    #endregion

    #region StealininIcon

    public void OneMoreSteal()
    {
        this.stealingNum++;
        ShowIcon();
    }

    public void OneLessSteal()
    {
        this.stealingNum--;
        ShowIcon();
    }

    private void ShowIcon()
    {
        if (stealingNum <= 0)
        {
            stealingIcon.SetActive(false);
            return;
        }
        stealingIcon.SetActive(true);
    }

    #endregion

    public static void GameOver(bool b)
    {
        if (b)
            GlobalScript.GoToScene("WinGameOver");
        else
            GlobalScript.GoToScene("LooseGameOver");
    }
}
