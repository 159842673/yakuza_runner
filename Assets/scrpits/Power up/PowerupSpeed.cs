using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class Powerup : MonoBehaviour
{
    public float increase = 5f;
    public Move2D playermove2d;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (playermove2d)
        {
            playermove2d.speed += increase;
            Destroy(gameObject);
        }

    }
}