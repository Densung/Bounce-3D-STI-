using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleDepleteHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            other.gameObject.transform.position = TPController.spawnPoint;
            SampleTextUpdate.number -= 1f;
        }
    }
}
