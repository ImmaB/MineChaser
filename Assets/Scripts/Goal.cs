using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject goalUI;
    private void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.CompareTag("Player"))
        {
            goalUI.SetActive(true);
           
        }
    }
}
