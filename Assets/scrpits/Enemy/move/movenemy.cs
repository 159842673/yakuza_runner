using UnityEngine;

public class movenemy : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 4;
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= moveSpeed * Time.fixedDeltaTime;
        if (pos.x < -11)
        {
            Destroy(gameObject);
        }
        transform.position = pos;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Die()
    {
        Destroy(gameObject);
    }

}
