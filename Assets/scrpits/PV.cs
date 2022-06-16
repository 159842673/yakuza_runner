using UnityEngine;
using UnityEngine.Events;

public class PV : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;
    [HideInInspector] public int currentHealth;
    private void Start()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage()
    {
        ModifyHealth(-1);
        damageTaken.Invoke();
        if (currentHealth <= 0)
            Destroy(gameObject);
    }
    public void Lambda()
    {
        ModifyHealth(-2);
        damageTaken.Invoke();
        if (currentHealth <= 0)
            Destroy(gameObject);
    }
    public void drone()
    {
        ModifyHealth(-3);
        damageTaken.Invoke();
        if (currentHealth <= 0)
            Destroy(gameObject);
    }
    public void OnCollisionEnter2D()
    {
        Lambda();
        TakeDamage();
        drone();
    }


    public void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }
}
