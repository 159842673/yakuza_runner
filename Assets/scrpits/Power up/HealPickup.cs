using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickup : MonoBehaviour
{
    private PV pv;

    public int healthToGive;

    private void Start()
    {
        pv = FindObjectOfType<PV>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
            pv.currentHealth += healthToGive;
            Destroy(this.gameObject);
        }
    }
}
