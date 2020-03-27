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
    
    public Vector2 gravity { get; private set; }
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
            if (Mathf.Abs(gyro.gravity.z) > 0.9)
            {
                gravity = (gyro.attitude * Vector2.up).normalized;
                gravity = new Vector2(-gravity.x, gravity.y);
                Debug.DrawRay(transform.position, gravity, Color.red);
            }
            else
            {
                gravity = gyro.gravity.To2D().normalized;
                Debug.DrawRay(transform.position, gravity, Color.green);
            }
        }
    }
}
