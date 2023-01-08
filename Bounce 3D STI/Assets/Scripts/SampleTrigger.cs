using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTrigger : MonoBehaviour
{
    public GameObject sampleObject;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            rb.isKinematic = false;
            Destroy(sampleObject);
        }
    }
}
