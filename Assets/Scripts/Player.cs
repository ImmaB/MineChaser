using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigbody;
    
    private void Awake()
    {
        rigbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GyroManager.instance.EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        bool grounded = true;
        SoundManager.SetMinecartSpeed(grounded ? rigbody.velocity.magnitude : 0);
    }

    public void OnRotate(InputAction.CallbackContext ctx)
    {
        // Quaternion rot = ctx.ReadValue<Quaternion>();
        // Debug.Log(rot);
    }

    private void OnDeath()
    {
        SceneLoader.instance.LoadScene(0);
    }
}
