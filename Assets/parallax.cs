using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class parallax : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject cam;
    public float parallaxeffect;
  
    // Update is called once per frame

    private void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    private void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxeffect));
        float dist = (cam.transform.position.x * parallaxeffect);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        if (temp > startpos + lenght) startpos += lenght;
        else if(temp < startpos -lenght) startpos -= lenght;
    }
}
