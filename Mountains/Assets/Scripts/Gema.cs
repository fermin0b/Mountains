using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : MonoBehaviour
{
    public Animator gema;
  //  public Move move;

    public bool once = true;
    private bool triggered;
   // public Transform target;
   // public float speed;
   // private bool activated = false;

    void Start()
    {
        gema.SetBool("ON", false);

    }


    void OnTriggerEnter(Collider otro)
    {
        if (!(triggered && once))
        {

           // float step = speed * Time.deltaTime;
           //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            gema.SetBool("ON", true);
           // move.Activate();
            triggered = true;
        }
    }

}
