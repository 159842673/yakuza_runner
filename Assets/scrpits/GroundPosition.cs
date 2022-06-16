using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPosition : MonoBehaviour
{
    public float startposition, endposition;
    public GameObject fond;
    public float parallaxeffect;

    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(startposition, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= endposition && transform.position.y <= startposition)
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        float temp = (fond.transform.position.x * (1 - parallaxeffect));
        float dist = (fond.transform.position.x * parallaxeffect);
        if (temp > startposition + endposition) startposition += endposition;
        else if (temp < startposition - endposition) startposition -= endposition;
    }
}
