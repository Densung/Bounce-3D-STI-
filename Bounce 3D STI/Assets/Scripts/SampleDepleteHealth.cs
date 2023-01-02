using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleDepleteHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            SampleTextUpdate.number -= 0.5f;
        }
    }
}
