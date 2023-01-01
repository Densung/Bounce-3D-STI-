using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeText : MonoBehaviour
{
    public GameObject[] earthquakeArray;
    public GameObject[] destroyObjectArray;
    public int earthquakeTime;

    void Start()
    {
        foreach (GameObject obj1 in earthquakeArray)
        {
            obj1.SetActive(false);
        }
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            foreach (GameObject earthquake in earthquakeArray)
            {
                earthquake.SetActive(true);
            }

            yield return new WaitForSeconds(earthquakeTime);

            foreach (GameObject earthquake in earthquakeArray)
            {
                earthquake.SetActive(false);
            }

            foreach (GameObject destroy in destroyObjectArray)
            {
                Destroy(destroy);
            }
        }
    }
}