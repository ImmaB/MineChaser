using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.InputSystem.Controls;

public class SensorTest : MonoBehaviour
{
    [SerializeField] private Android android;
    private TMPro.TextMeshProUGUI text;
    /*
    UnityEngine.InputSystem.Gyroscope gyro;
    // Start is called before the first frame update
    void OnEnable()
    {
        InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
        gyro = UnityEngine.InputSystem.Gyroscope.current;
    }
    private void OnDisable()
    {
        InputSystem.DisableDevice(UnityEngine.InputSystem.Gyroscope.current);
    }
    */
    // Update is called once per frame
    private void Awake()
    {
        //android = new Android();
        text = GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        //android.PlayerAndroid.Enable();
        InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
        

    }
    private void OnDisable()
    {
        //android.PlayerAndroid.Disable();
        InputSystem.DisableDevice(UnityEngine.InputSystem.Gyroscope.current);
    }
    private void Update()
    {
        //Debug.Log(android.PlayerAndroid.Gyro.ReadValue<Vector3>());
        //Vector3Control  test = UnityEngine.InputSystem.Gyroscope.current.angularVelocity;

        //text.text = "" + test.x.scaleFactor;
    }
}
