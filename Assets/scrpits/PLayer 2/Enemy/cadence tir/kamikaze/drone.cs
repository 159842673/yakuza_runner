using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone : MonoBehaviour
{
    PV pa;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            Die();
            pa.drone();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}