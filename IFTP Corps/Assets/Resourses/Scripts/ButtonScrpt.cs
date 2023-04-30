using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScrpt : MonoBehaviour
{
    [SerializeField]DeskBehavious dbInstance;

    [SerializeField] GameObject buttonEsclude, buttonUpgrade;

    [SerializeField] private Dictionary<string, GameObject> listaDeTorres;

    bool clickedInButton;

    GMScript gmInstance;

    private void Awake()
    {
        gmInstance = GameObject.FindGameObjectWithTag("GameController").GetComponent<GMScript>();

        ActiveBools(false);
    }

    private void Start()
    {
        listaDeTorres = EnemyTowerDictionary.GetDicionaryDeTorres();
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (clickedInButton)
            {
                clickedInButton = false;
                return;
            }
            ActiveBools(false);
        }
    }

    public void OnOpenClick()
    {
        ActiveBools(true);
        dbInstance.PlaceTower(listaDeTorres["Advogado"], gmInstance);
    }

    public void ActiveBools(bool b)
    {
        clickedInButton = b;
        buttonEsclude.SetActive(b);
        buttonUpgrade.SetActive(b);
        dbInstance.SelectTower(b);
    }
}
