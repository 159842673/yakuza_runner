using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgunenemy : MonoBehaviour
{
    private Shooter2D shooter;
  
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating("shoot", 0f, 2f);
    }
    private void shoot()
    {
        shooter.Shoot();
    }
    /*private void Shoot()
    {
        shooter.Shoot();
    }*/
}
