using UnityEngine;

public class Lambda1: MonoBehaviour
{
    private Shooter2D shooter;
    PV pa;

    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, .8f);
        pa = GetComponent<PV>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            Die();
            pa.Lambda();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    private void Shoot()
    {
        shooter.Shoot();
    }
}
