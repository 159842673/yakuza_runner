using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movestate : MonoBehaviour
{
    public Transform point;
    public float t;
    void Start()
    {

    }
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector2 a = transform.position;
        Vector2 b = point.position;
        transform.position = Vector2.Lerp(a, b, t);
    }
}
