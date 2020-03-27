using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    #region Instance
    public static GyroManager instance { get; private set; }
    public Quaternion zRotation { get; private set; }

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
    
    public float rotation { get; private set; }
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
            // rotation = gyro.attitude;
            // rotation = gyro.attitude;
            Vector3 rot = gyro.gravity;
            // zRotation = Quaternion.Euler(rot);
            // zRotation = Quaternion.Euler(new Vector3(0, 0, rotation.eulerAngles.z));
            // gravity = gyro.gravity.WithZ(0).normalized;
            gravity = gyro.gravity.To2D().normalized;
            // gravity = new Vector2(-gravity.x, gravity.y);
            Debug.DrawRay(transform.position, gravity);
            // float angle = Vector2.Angle(gravity, Vector2.down);
            // zRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            // zRotation = Quaternion.FromToRotation(gravity, Vector2.down);



            rotation = -Vector2.SignedAngle(gravity, Vector2.down);
        }
    }
}
