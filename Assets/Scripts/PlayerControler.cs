using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D rb;
    float xInput;
    float yInput;
    Vector2 newPosition;
    public float movementSpeed = 0.3f;
    public float xPositionLimit;
    public GameObject pea;
    public float fireRate;
    public float lastFired;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        xInput = Input.GetAxis("Horizontal");
        newPosition = transform.position;
        newPosition.x += xInput * movementSpeed;
        newPosition.x = Mathf.Clamp(newPosition.x, -xPositionLimit, xPositionLimit);
        rb.MovePosition(newPosition);

        yInput = Input.GetAxis("Vertical");
        if (yInput > 0 && lastFired > fireRate)
        {
            FirePea();
            lastFired = 0;
        }
        else
        {
            lastFired += Time.deltaTime;
        }
    }
    private void FirePea()
    {
        Vector2 newPos = pea.transform.position;
        newPos.x = newPosition.x - 0.40f;
        Instantiate(pea, newPos, Quaternion.identity);
        lastFired += Time.deltaTime;
    }
}
    
