using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    private float gravityMagnitude;
    // [SerializeField]
    // private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        GyroManager.instance.EnableGyro();
        gravityMagnitude = Physics2D.gravity.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.gravity = GyroManager.instance.gravity * gravityMagnitude;
    }
}
