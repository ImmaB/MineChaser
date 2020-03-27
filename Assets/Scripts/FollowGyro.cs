using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    // [SerializeField]
    // private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        GyroManager.instance.EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
