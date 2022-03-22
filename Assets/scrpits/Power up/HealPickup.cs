using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickup : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PV>(out var playerLife))
        {
            playerLife.currentHealth += 10;
            playerLife.TakeDamage();
            Destroy(gameObject);
        }
    }
}
