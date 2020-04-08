using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private float collisionForceThreshold = 0;
    [SerializeField] private bool playSoundWhenSpinning = false;

    private Rigidbody2D rigbody;
    
    private void Awake()
    {
        rigbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (playSoundWhenSpinning)
            SoundManager.SetWheelSpinSpeed(Mathf.Abs(rigbody.angularVelocity / 360f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > collisionForceThreshold)
            SoundManager.PlayGroundHit();
    }
}
