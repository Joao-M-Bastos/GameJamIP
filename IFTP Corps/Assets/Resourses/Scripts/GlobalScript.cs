using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GlobalScript
{
    public static void GoToScene(string sceneName = "", int? sceneID = null)
    {
        if(sceneName != "")
            SceneManager.LoadScene(sceneName);

        if (sceneID != null)
            SceneManager.LoadScene((int)sceneID);

        NumOfEnemiesAlive.Zero();
    }
}
