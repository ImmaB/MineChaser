using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        GyroManager.instance.EnableGyro();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SoundManager.PlayCrystalHit();
            SceneLoader.OnDeath();
        }
    }
}
