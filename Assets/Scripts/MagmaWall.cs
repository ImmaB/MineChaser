using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class MagmaWall : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("DEAD");
            collision.gameObject.SetActive(false);
        }
    }
}
