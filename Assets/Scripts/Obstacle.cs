using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-145, -60)));
    }

    void FixedUpdate()
    {
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.ShowGameOver();
        }
    }
}
