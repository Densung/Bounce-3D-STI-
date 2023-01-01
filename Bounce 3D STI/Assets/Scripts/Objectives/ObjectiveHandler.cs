using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveHandler : MonoBehaviour
{
    public GameObject[] ObjectiveArray1;
    public GameObject[] ObjectiveArray2;
    public GameObject[] destroyObjectArray;

    void Start()
    {
        foreach (GameObject obj1 in ObjectiveArray1)
        {
            obj1.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            foreach (GameObject obj1 in ObjectiveArray1)
            {
                obj1.SetActive(true);
            }

            foreach (GameObject obj2 in ObjectiveArray2)
            {
                obj2.SetActive(false);
            }

            foreach (GameObject destroy in destroyObjectArray)
            {
                Destroy(destroy);
            }
        }
    }
}