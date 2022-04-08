using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armure : MonoBehaviour
{
    public SpriteRenderer Sprite;
    GameObject shield;
    void Start()
    {
    

    }


    // Update is called once per frame
    void Update()
    {
        if (Sprite != null)
        {
            Sprite.enabled = !Sprite.enabled;
        }
    }

}
