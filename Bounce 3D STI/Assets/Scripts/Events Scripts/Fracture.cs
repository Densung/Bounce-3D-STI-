using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject fractured;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Vector3 oldPos = transform.position;
            Instantiate(fractured, oldPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
