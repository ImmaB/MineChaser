using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [SerializeField]
    private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        GyroManager.Instance.EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localRotation = Quaternion.Euler(GyroManager.Instance.GetGravityRot() * 50);//baseRotation;
        //transform.localRotation = Quaternion.Euler(new Vector3(0, 0, Input.acceleration.x * 50));//Quaternion.Euler(Input.acceleration * 50);
        transform.localRotation = Quaternion.Euler(new Vector3(0,0,GyroManager.Instance.GetGyroRotation().eulerAngles.z));
        //z seems to be the key
        Debug.Log(GyroManager.Instance.GetGyroRotation().eulerAngles);
    }
}
