using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject goalUI = null;
    [SerializeField]
    private GameObject goalCage = null;
    private void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.CompareTag("Player"))
        {
            if (goalUI == null)
                goalUI = FindObjectOfType<ResultScreen>().gameObject;
            goalUI.SetActive(true);
            goalCage.SetActive(true);
        }
    }
}
