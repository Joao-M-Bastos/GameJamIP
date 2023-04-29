using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    [SerializeField] private static int life;

    public Text text;

    private void Awake()
    {
        
        life = 3;
        getLife();
    }
    public int getLife()
    {
        text.text = "Vida: " + life;
        return life;
    }

    public void playerTakeADamage()
    {
        life--;
    }
}
