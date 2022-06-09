using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followtarget : MonoBehaviour
{
    [SerializeField] private GameObject Target;
    [SerializeField] float Speed ;

    // Update is called once per frame
    void Start()
    {
        Target = GetComponent<GameObject>();
    }
    void Update()
    {
        Target = GameObject.FindGameObjectWithTag("target");
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, Speed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
          Destroy(this.gameObject);
        }
    }

}
