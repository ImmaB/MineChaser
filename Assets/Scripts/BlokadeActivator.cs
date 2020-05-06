using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokadeActivator : MonoBehaviour
{
    [SerializeField]
    GameObject blokade;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        blokade.SetActive(true);
    }
}
