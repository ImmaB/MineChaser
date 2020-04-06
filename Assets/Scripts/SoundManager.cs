using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Instance
    public static SoundManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    #endregion

    [SerializeField] private AudioSource minecart;

    public static void SetMinecartSpeed(float speed)
    {
        if (speed < 0.1) speed = 0;
        if (speed > 0)
        {
            if (!instance.minecart.isPlaying)
                instance.minecart.Play();
            instance.minecart.pitch = speed;
        }
        else
            instance.minecart.Stop();
    }
}
