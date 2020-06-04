using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    public int bumpCount = 0;
    [SerializeField]
    private int bumpMax = 3;

    [SerializeField]
    private SpriteRenderer helmetRenderer;
    [SerializeField]
    private Sprite normalHelmet;
    [SerializeField]
    private Sprite crackedHelmet;

    public int BumpMax
    {
        get { return bumpMax; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.PlayHeadHit();
        bumpCount++;
        Debug.Log(bumpCount);
        if (bumpCount < 3)
            helmetRenderer.sprite = new Sprite[]{ normalHelmet, crackedHelmet, null }[bumpCount];
        else
            GameStateManager.SetState(GameState.GameOver);
    }
}

