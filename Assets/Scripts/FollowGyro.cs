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
        //transform.localRotation = Quaternion.Euler(GyroManager.Instance.GetGravityRot() * 50);//baseRotation;
        //transform.localRotation = Quaternion.Euler(new Vector3(0, 0, Input.acceleration.x * 50));//Quaternion.Euler(Input.acceleration * 50);
        transform.localRotation = GyroManager.instance.zRotation;

        //z seems to be the key
        // Debug.Log(GyroManager.instance.rotation.eulerAngles);
        Physics2D.gravity = GyroManager.instance.gravity * gravityMagnitude;
        // Debug.DrawRay(transform.position, Physics2D.gravity, Color.red);
        //GyroManager.instance.gravity.To2D().normalized * gravityMagnitude;

    }
}
