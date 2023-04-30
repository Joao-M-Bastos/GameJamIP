using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenManager : MonoBehaviour
{
    public void OnButtonClick()
    {
        GlobalScript.GoToScene("", 0) ;
    }
}
