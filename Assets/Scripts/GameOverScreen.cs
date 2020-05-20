using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public void OnRetry()
    {
        SceneLoader.Reload();
    }

    public void OnBackToTitle()
    {
        SceneLoader.LoadTitleScreen();
    }
}
