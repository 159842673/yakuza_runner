using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move2D : MonoBehaviour
{
    public float speed;

    [HideInInspector] public Vector2 direction;

    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb2D.velocity = direction.normalized * speed;
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("Coucou");
        direction = value.Get<Vector2>();
    }
}

