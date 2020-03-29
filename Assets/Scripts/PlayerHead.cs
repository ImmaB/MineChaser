using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    public int bumpCount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bumpCount++;
        Debug.Log(bumpCount);
    }
}
