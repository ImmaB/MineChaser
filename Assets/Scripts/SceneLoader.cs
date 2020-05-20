using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private float deathDelay = 1;
    [SerializeField] private GameObject deathScreen;
    public static SceneLoader instance { get; private set; }

    private void OnEnable()
    {
        if (instance == null) instance = this;
        else Destroy(this.gameObject);
    }

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

    public static void OnDeath()
    {
        instance.deathScreen.SetActive(true);
        GyroManager.instance.DisableGyro();
    }
}
