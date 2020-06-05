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

    private float attitudeCorrection;
    private bool trackRotation = false;
    public static Quaternion rotation { get { return Quaternion.Euler(0, 0, -Physics2D.gravity.ToAngle() + 180); } }

    public void EnableGyro()
    {
        if (trackRotation) return;
        trackRotation = true;
        if (SystemInfo.supportsGyroscope)
            Input.gyro.enabled = true;
    }

    public void DisableGyro()
    {
        trackRotation = false;
    }

    private void Update()
    {
        if (!trackRotation) return;
        Vector2 gravityDirection = Vector2.zero;
        if (SystemInfo.supportsGyroscope)
        {
            if (Mathf.Abs(Input.gyro.gravity.z) > 0.9) // phone aligned face up or down => cannot use gravity
            {
                if (attitudeCorrection == 0)
                    attitudeCorrection = GetAttitudeCorrection();
                gravityDirection = GetGravityFromAttitude(Input.gyro.attitude).RotateBy(attitudeCorrection);
            }
            else
            {
                attitudeCorrection = 0;
                gravityDirection = Input.gyro.gravity.To2D().normalized;
            }
        }
        else
        {
            // Using accelerometer much worse
        }
        Physics2D.gravity = gravityDirection * Physics2D.gravity.magnitude;
    }

    private float GetAttitudeCorrection()
    {
        Vector2 realGravity = Input.gyro.gravity.To2D();
        Vector2 gravityFromAttitude = GetGravityFromAttitude(Input.gyro.attitude);
        return realGravity.ToAngle() - gravityFromAttitude.ToAngle();
    }

    private Vector2 GetGravityFromAttitude(Quaternion attitude)
    {
        Vector2 g = (attitude * Vector2.up).normalized;
        return new Vector2(-g.x, g.y);
    }

}
