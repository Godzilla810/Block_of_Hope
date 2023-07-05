using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_right_enemy : MonoBehaviour
{
    public float speed = 5f; // Speed of enemy movement
    private Animator animator;
    private bool movingUp = true; // Flag to track movement direction

    private void Update()
    {
        if (movingUp)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            // if (transform.position.y >= topPoint.position.y)
            // {
            //     movingUp = false;
            // }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            // if (transform.position.y <= bottomPoint.position.y)
            // {
            //     movingUp = true;
            // }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            movingUp = !movingUp;
        }
        // else if (collision.gameObject.CompareTag("Player"))
        // {
        //     animator.SetTrigger("Collide");
        // }
    } 
}