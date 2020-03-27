using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if (AttitudeSensor.current == null)
        //     Debug.LogError("No AttitudeSensor found");
        // else
        //     InputSystem.EnableDevice(AttitudeSensor.current);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnRotate(InputAction.CallbackContext ctx)
    {
        // Quaternion rot = ctx.ReadValue<Quaternion>();
        // Debug.Log(rot);
    }
}
