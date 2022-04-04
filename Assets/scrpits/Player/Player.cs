using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private Move2D move;
    private Shooter2D shooter;

    private void Awake()
    {
        move = GetComponent<Move2D>();
        shooter = GetComponent<Shooter2D>();
    }

    private void OnMove(InputValue value)
    {
        move.direction = value.Get<Vector2>();
    }

    private void OnFire()
    {
        shooter.Shoot();
    }
}
