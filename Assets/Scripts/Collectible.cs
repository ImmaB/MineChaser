using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void Start()
    {
        transform.Rotate(new Vector3(0, 0, Rand.Float(90)));
    }

    public float score = 2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreSystem.instance.AddScore(score);
            SoundManager.PlayCollectible();
            gameObject.SetActive(false);
        }
    }
}
