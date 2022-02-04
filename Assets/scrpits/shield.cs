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

    // Update is called once per frame
    public void OnShield(InputAction.CallbackContext ctx)
    {
       
       
            if (ctx.performed)
            {
                shields.SetActive(true);
                ActiveShield = true;
            }
            if(ctx.canceled)
            {
                shields.SetActive(false);
                ActiveShield = true;
            }
       
    }

   
}


