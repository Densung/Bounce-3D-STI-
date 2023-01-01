using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdObj : MonoBehaviour
{
    public GameObject uiObject2;
    public GameObject uiObject3;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            uiObject2.SetActive(false);
            uiObject3.SetActive(true);
            Destroy(uiObject2);
            Destroy(gameObject);
        }
    }
}