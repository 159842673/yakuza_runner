using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Shooter2D shooter;


    void Awake()
    {
        shooter = GetComponent<Shooter2D>();
    }
   
    private void OnFire()
    {
        shooter.Shoot();
    }
}
