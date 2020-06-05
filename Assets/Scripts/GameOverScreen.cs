using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    private void OnEnable()
    {
        transform.rotation = GyroManager.rotation;
    }

    public void OnRetry()
    {
        SceneLoader.Reload();
    }

    public void OnBackToTitle()
    {
        SceneLoader.LoadTitleScreen();
    }
}
