/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedTrigger : FailedMenu
{
    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            yield return new WaitForSeconds(600);
            Pause();
        }
    }
}*/