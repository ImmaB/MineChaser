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
    public int collectibleCount { get; private set;}
    public int maxCollectibleCount { get; private set; }
    public float timeStart { get; private set; }

    //needed?
    private GameObject player;


    private void OnEnable()
    {
        if(!player)
            player = GameObject.FindObjectOfType<Player>().gameObject;
        score = 0;
        collectibleCount = 0;
        maxCollectibleCount = FindObjectsOfType<Collectible>().Length;
        timeStart = Time.time;
    }
    public void AddScore(float addScore)
    {
        score += addScore;
        collectibleCount++;
    }
}
