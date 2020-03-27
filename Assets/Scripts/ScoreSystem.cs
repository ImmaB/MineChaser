using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    private float multiplier = 5f;
    private float score = 0;
    [SerializeField]
    private TextMeshProUGUI text;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.activeSelf)
        {

            score += Time.deltaTime * multiplier;
        }
        text.text = "Score: " + Mathf.Floor(score);
    }
}
