using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject followTarget;


    private void Awake()
    {
        if (!followTarget)
            followTarget = GameObject.FindGameObjectWithTag("Player");         
    }

    // Update is called once per frame
    private void Update()
    {
        if (followTarget)
            transform.position = followTarget.transform.position.WithZ(transform.position.z);
    }
}
