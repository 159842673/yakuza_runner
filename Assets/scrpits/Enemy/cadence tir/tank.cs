using UnityEngine;

public class tank: MonoBehaviour
{
    private Shooter2D shooter;
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, 1f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}
