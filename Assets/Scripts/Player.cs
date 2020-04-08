using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private void Start()
    {
        GyroManager.instance.EnableGyro();
    }

    private void OnDeath()
    {
        SceneLoader.instance.LoadScene(0);
    }
}
