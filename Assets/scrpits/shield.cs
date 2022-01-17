using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shield : MonoBehaviour
{
    public GameObject Shield;

    public shield(GameObject shield)
    {
        this.Shield = shield;
    }

    private bool activateShield;
    // Start is called before the first frame update
    void Start()
    {
        activateShield = false;
        shield.SetActive(false);
    }

    private static void SetActive(bool v)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    public void OnShield(InputAction.CallbackContext ctx)
    {
       
       
            if (ctx.performed)
            {
                shield.SetActive(true);
                ActiveShield = true;
            }
            if(ctx.canceled)
            {
                shield.SetActive(false);
                ActiveShield = true;
            }
       
    }

    public bool ActiveShield
    {
        get
        {
            return ActiveShield;
        }
        set
        {
            activateShield = value;
        }
    }
}


