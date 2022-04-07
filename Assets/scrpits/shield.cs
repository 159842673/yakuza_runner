using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shield : MonoBehaviour
{
    public GameObject shields;

    public bool ActiveShield { get; private set; }

    private static void SetActive(bool v)
    {
        throw new NotImplementedException();
    }

    public IEnumerator Shield()
    {
        shields.SetActive(true);
        yield return new WaitForSeconds(10);
        shields.SetActive(false);

    }
    public void OnShield(InputValue value)
    {
        if (value.isPressed)
        {
            StartCoroutine(Shield());
        }
       
       
    }

   
}


