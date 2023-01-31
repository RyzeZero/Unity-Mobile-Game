using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    void FixedUpdate()
    {
        rig.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.AddScore();
            Destroy(gameObject);
        }
    }
}
