using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScrpt : MonoBehaviour
{
    [SerializeField]DeskBehavious dbInstance;
    public void OnOpenClick()
    {
        dbInstance.SelectDesc();
    }
}
