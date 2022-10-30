using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaneLoaderManager : MonoBehaviour
{
    //Load
    public static void Load(string sceneName)
    {
        SceneLoader.Load(sceneName);
    }

    //progress Load
    public static void ProgressLoad(string sceneName)
    {
        SceneLoader.ProgressLoad(sceneName);
    }

    //Reload Level
    public static void ReloadLevel()
    {
        SceneLoader.ReloadLevel();
    }

    //LoadNextLevel
    public static void LoadNextLevel()
    {
        SceneLoader.LoadNextLevel();
    }
}
