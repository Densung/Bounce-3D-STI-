using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionalObjectives : MonoBehaviour
{
    public GameObject disableObj, spawnObj, spawnQ, optionalObj;
    public GameObject[] destroyObjects;

    void Start()
    {
        spawnObj.SetActive(false);
        spawnQ.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("PWD"))
        {
            spawnObj.SetActive(true);
            disableObj.SetActive(false);
            optionalObj.SetActive(true);
            foreach (GameObject destroy in destroyObjects)
            {
                Destroy(destroy);
            }
        }
        if (col.gameObject.tag.Equals("Player"))
        {
            spawnQ.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            spawnQ.SetActive(false);
        }
    }
}