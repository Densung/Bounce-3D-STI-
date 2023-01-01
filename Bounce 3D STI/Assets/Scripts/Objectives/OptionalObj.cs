using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionalObj : MonoBehaviour
{
    public GameObject uiObject4;
    void Start()
    {
        uiObject4.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            uiObject4.SetActive(true);
            Destroy(gameObject);
        }
    }
}