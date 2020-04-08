using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScreen : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI collCount;
    [SerializeField]
    private TextMeshProUGUI lifeCount;
    [SerializeField]
    private TextMeshProUGUI time;
    private PlayerHead playerHead; 
    private void OnEnable()
    {
        if (playerHead == null)
            playerHead = FindObjectOfType<PlayerHead>();
        if (collCount)
            collCount.text = "Collectibles " + ScoreSystem.instance.collectibleCount + "/" + ScoreSystem.instance.maxCollectibleCount;
        if (lifeCount)
            lifeCount.text = "Durability " + playerHead.bumpCount + "/" + playerHead.BumpMax;
        if (time)
            time.text = (int)(Time.time - ScoreSystem.instance.timeStart) + "Sec.";
    }
    public void LoadLevel(int index)
    {
        SceneLoader.instance.LoadScene(index);
    }

}
