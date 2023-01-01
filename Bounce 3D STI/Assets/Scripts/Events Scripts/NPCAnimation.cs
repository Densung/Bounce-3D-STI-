using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator[] npcAnimArray;
    public GameObject[] triggers;
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            foreach (Animator npcAnim in npcAnimArray)
            {
                npcAnim.SetBool("isMoving", true);
            }

            foreach (GameObject trigger in triggers)
            {
                Destroy(trigger);
            }
        }
    }
}