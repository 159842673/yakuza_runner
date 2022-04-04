using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    private Move2D move;

    private void Awake()
    {
        move = GetComponent<Move2D>();
    }

    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player1");
    }

    private void OnMove(InputValue value)
    {
        move.direction = value.Get<Vector2>();
    }
}
