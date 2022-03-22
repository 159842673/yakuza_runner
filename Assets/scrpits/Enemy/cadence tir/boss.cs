using UnityEngine;

public class boss : MonoBehaviour
{
    private Shooter2D shooter;
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, .5f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}