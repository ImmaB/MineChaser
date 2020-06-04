using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private GameObject PauseButton = null;
    [SerializeField] private GameObject PauseMenu = null;

    public void SetPause(bool pause = true)
    {
        GameStateManager.SetState(pause ? GameState.Pause : GameState.Playing);
        PauseButton.SetActive(!pause);
        PauseMenu.SetActive(pause);
    }
    
    public void OnBackToTitle()
    {
        SceneLoader.LoadTitleScreen();
    }
}
