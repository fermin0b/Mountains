using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform target;
    public float speed;
    private bool activated = false;



    void Update()
    {
        if (activated)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public void Activate()
    {
        activated = true;
    }

}
