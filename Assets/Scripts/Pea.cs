using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pea : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 newPosition;
    public float movementSpeed = 0.2f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        newPosition = transform.position;
        newPosition.y += 1 * movementSpeed;
        rb.MovePosition(newPosition);
        if (transform.position.y > 5.0f)
        {
            Destroy(transform.gameObject);
        }
    }
}
