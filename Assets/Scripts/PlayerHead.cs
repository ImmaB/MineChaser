using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    public int bumpCount;
    [SerializeField]
    private int bumpMax = 3;

    public int BumpMax
    {
        get { return bumpMax; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bumpCount++;
        SoundManager.PlayHeadHit();
        Debug.Log(bumpCount);
    }
}
