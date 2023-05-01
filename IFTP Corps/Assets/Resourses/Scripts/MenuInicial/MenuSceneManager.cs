using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour
{
    public void OnChangeSceenClick(int i)
    {
        GlobalScript.GoToScene("Fase_1");
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
