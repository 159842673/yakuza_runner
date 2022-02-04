using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class PowerupSpeed : MonoBehaviour
{
    public float increase = 5f;
    public Move2D playermove2d;


    private void OnCollision2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.SendMessage("ApplySpeed");


        }
    }
}