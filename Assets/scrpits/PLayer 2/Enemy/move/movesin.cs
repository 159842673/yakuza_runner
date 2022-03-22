using UnityEngine;

public class movesin : MonoBehaviour
{
    float sincenterY;
    public float amplitude = 2;
    public float frequency = 2;
    public bool inverted = false;
    void Start()
    {
        sincenterY = transform.position.y;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        float sin = Mathf.Sin(pos.x) * amplitude;
        if (inverted)
        {
            sin *= 1;
        }
        pos.y = sincenterY + sin;

        transform.position = pos;
    }
}
