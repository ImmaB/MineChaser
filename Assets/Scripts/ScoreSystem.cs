using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    #region Instance
    public static ScoreSystem instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    #endregion

    private float multiplier = 5f;
    public float score { get; private set; }

    private GameObject player;

    private void OnEnable()
    {
        if(!player)
            player = GameObject.FindGameObjectWithTag("Player");
        score = 0;
    }
    public void AddScore(float addScore)
    {
        score += addScore;
    }
}
