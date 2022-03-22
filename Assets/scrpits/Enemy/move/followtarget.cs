using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtarget : MonoBehaviour
{
    [SerializeField] private GameObject Target;
    [SerializeField] float speed ;

    // Update is called once per frame
    void Start()
    {
     
    }
    void Update()
    {
        Target = GameObject.FindGameObjectWithTag("target");
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, speed * Time.deltaTime);
       
    }

}
