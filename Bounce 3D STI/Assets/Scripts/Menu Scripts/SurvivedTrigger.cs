using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivedTrigger : SurvivedMenu
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
            Pause();
    }
}
