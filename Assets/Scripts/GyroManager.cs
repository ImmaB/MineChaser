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
        gravityMagnitude = Physics2D.gravity.magnitude;
    }
    #endregion

    [Header("Logic")]
    private Gyroscope gyro;
    private bool gyroActive;
    private float attitudeCorrection;
    private float gravityMagnitude;
    private Vector2 gravity;

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
            Debug.LogError("Gyro is not supportet on this device");
        }

    }
    public void DisableGyro()
    {
        gyroActive = false;
    }

    private void Update()
    {
        if (gyroActive)
        {
            if (Mathf.Abs(gyro.gravity.z) > 0.9) // phone aligned face up or down => cannot use gravity
            {
                if (attitudeCorrection == 0)
                    attitudeCorrection = GetAttitudeCorrection();
                gravity = GetGravityFromAttitude(gyro.attitude).RotateBy(attitudeCorrection);
            }
            else
            {
                attitudeCorrection = 0;
                gravity = gyro.gravity.To2D().normalized;
            }
            Physics2D.gravity = gravity * gravityMagnitude;
        }
    }

    private float GetAttitudeCorrection()
    {
        Vector2 realGravity = gyro.gravity.To2D();
        Vector2 gravityFromAttitude = GetGravityFromAttitude(gyro.attitude);
        return realGravity.ToAngle() - gravityFromAttitude.ToAngle();
    }

    private Vector2 GetGravityFromAttitude(Quaternion attitude)
    {
        Vector2 g = (attitude * Vector2.up).normalized;
        return new Vector2(-g.x, g.y);
    }

}
