using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 newPosition;
    float movementSpeed;
    public float rotationSpeed;
    bool updatePos = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed);

        if (updatePos)
        {
            newPosition = transform.position;
            newPosition.y += 1 * movementSpeed;
            rb.MovePosition(newPosition);
        }
        
        if (transform.position.y < -5f)
        {
            Destroy(transform.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.instance.GameOver();
        }
        else if (collision.gameObject.tag == "Pea")
        {
            GameManager.instance.UpdateScore();
            Destroy(collision.gameObject);
            AudioManager.instance.Audio_Splat();
            StartCoroutine(x());

        }
        else if (collision.gameObject.tag == "Finish")
        {
            GameManager.instance.GameOver();
        }
    }
    IEnumerator x()
    {
        rotationSpeed = 50;
        movementSpeed = 0.1f;
        updatePos = true;
        yield return new WaitForSecondsRealtime(1);
        Destroy(gameObject);
    }
}

    