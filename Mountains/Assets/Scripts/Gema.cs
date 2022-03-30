using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : MonoBehaviour
{
    public Animator gema;
    public Move move;

    public bool once = true;
    private bool triggered;

    void Start()
    {
        gema.SetBool("ON", false);

    }
    void OnTriggerExit(Collider otro)
    {
        if (!(triggered && once))
        {
            gema.SetBool("ON", true);
            move.Activate();
            triggered = true;
        }
    }

}
