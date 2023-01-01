using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisFallEvent : MonoBehaviour
{
    [SerializeField] public int fallTime;
    public Rigidbody[] rbArray;

    void Start()
    {

    }

    // if the player steps in the collider, the debris will fall and the player will take damage
    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            yield return new WaitForSeconds(fallTime);
            foreach (Rigidbody rb in rbArray)
            {
                rb.isKinematic = false;
            }
        }
    }
}