using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public static void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public static void LoadTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public static bool IsTitle()
    {
        return SceneManager.GetActiveScene().name == "Title";
    }
}
