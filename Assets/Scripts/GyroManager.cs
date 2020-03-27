using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    #region Instance
    public static GyroManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    #endregion

    [Header("Logic")]
    private Gyroscope gyro;
    
    public Quaternion rotation { get; private set; }
    public Vector3 gravityRot { get; private set; }
    private bool gyroActive;

    public void EnableGyro()
    {
        if (gyroActive)
            return;
        
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }
        else
        {
            Debug.Log("Gyro is not supportet on this device");
        }

    }
    private void Update()
    {
        if (gyroActive)
        {
            rotation = gyro.attitude;
            gravityRot = gyro.gravity;
        }
    }
}
