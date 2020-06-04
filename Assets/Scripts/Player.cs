using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        GameStateManager.SetState(GameState.Playing);
        if (SceneLoader.IsTitle())
            SoundManager.PlayTitleBGM();
        else
            SoundManager.PlayLevelBGM();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SoundManager.PlayCrystalHit();
            GameStateManager.SetState(GameState.GameOver);
        }
    }
}
