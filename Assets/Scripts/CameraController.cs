using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject followTarget;

    // Update is called once per frame
    void Update()
    {
        if (followTarget)
            transform.position = followTarget.transform.position.WithZ(transform.position.z);
    }
}
