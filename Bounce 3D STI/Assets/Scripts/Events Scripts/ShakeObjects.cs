using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeObjects : MonoBehaviour
{
    [SerializeField]
    private Animator[] animArray;
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            foreach (Animator objectAnim in animArray)
            {
                objectAnim.SetBool("isShaking", true);
            }
        }
    }
}