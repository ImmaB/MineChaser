using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Pause, GameOver, Goal, Playing
}

public class GameStateManager : MonoBehaviour
{
    #region Instance
    public static GameStateManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    #endregion

    [SerializeField] private GameObject gameOverScreen = null;
    [SerializeField] private GameObject goalScreen = null;
    [SerializeField] private GameObject pauseScreen = null;
    private static GameState state = GameState.Playing;

    public static void SetState(GameState newState)
    {
        if (HandleStateChange(newState))
            state = newState;
    }

    private static bool HandleStateChange(GameState newState)
    {
        switch (newState)
        {
            case GameState.GameOver:
                if (!instance.gameOverScreen) return false;
                instance.gameOverScreen.SetActive(true);
                instance.pauseScreen.SetActive(false);
                PauseGamePhysics();
                return true;
            
            case GameState.Goal:
                if (!instance.goalScreen) return false;
                instance.goalScreen.SetActive(true);
                instance.pauseScreen.SetActive(false);
                PauseGamePhysics();
                return true;
            
            case GameState.Pause:
                if (!instance.pauseScreen) return false;
                PauseGamePhysics();
                return true;

            case GameState.Playing:
                PauseGamePhysics(false);
                return true;
        }
        return false;
    }

    private static void PauseGamePhysics(bool pause = true)
    {
        Time.timeScale = pause ? 0 : 1;
        if (pause)
            GyroManager.instance.DisableGyro();
        else
            GyroManager.instance.EnableGyro();
    }
}
