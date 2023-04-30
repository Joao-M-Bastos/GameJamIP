using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScrpt : MonoBehaviour
{
    [SerializeField]DeskBehavious dbInstance;

    [SerializeField] GameObject buttonEsclude, buttonUpgrade;

    bool clickedInButton;

    private void Awake()
    {
        ActiveBools(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && !clickedInButton)
        {
            ActiveBools(false);
        }
    }

    public void OnOpenClick()
    {
        ActiveBools(true);
        dbInstance.SelectDesc();
    }

    public void ActiveBools(bool b)
    {
        clickedInButton = b;
        buttonEsclude.SetActive(b);
        buttonUpgrade.SetActive(b);
    }
}
