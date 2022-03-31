using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void FixedUpdate()
    {
        transform.position = target.position + offset;  
    }

    private void Update()
    {
        if (!target)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }










}


