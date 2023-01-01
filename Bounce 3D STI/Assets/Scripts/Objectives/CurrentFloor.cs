using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentFloor : MonoBehaviour
{
    public GameObject[] floorUIArray, destroyFloorUIArray, destroyColliderArray;

    void Start()
    {
        foreach (GameObject floor in floorUIArray)
        {
            floor.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            foreach (GameObject floorUI in floorUIArray)
            {
                floorUI.SetActive(true);
            }

            foreach (GameObject destroyFloorUI in destroyFloorUIArray)
            {
                Destroy(destroyFloorUI);
            }

            foreach (GameObject destroyCollider in destroyColliderArray)
            {
                Destroy(destroyCollider);
            }
        }
    }
}