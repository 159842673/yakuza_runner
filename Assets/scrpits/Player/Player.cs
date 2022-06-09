using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private Move2D move;
    private Shooter2D shooter;
    GameObject shield;
    private bool Buff = true;
    private Gun Shotgun;

    private void Awake()
    {
        move = GetComponent<Move2D>();
        shooter = GetComponent<Shooter2D>();
        Shotgun = GetComponent<Gun>();
    }
    public void Start()
    {
        shield = transform.Find("shield").gameObject;
    }
    //Buff player shield
    void activeshield()
    {
        shield.SetActive(true);
    }
    void deactivateshield()
    {
        shield.SetActive(false);
    }
    private void OnMove(InputValue value)
    {
        move.direction = value.Get<Vector2>();
    }

    private void OnFire()
    {
        shooter.Shoot();
    }
    bool Hashield()
    {
        return shield.activeSelf;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("target"))
        {
            if (Hashield())
            {
                deactivateshield();
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}
