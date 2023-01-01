using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceTrigger : MonoBehaviour
{
    public GameObject[] choiceArray, destroyChoiceArray, spawnObjects;
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            foreach (GameObject choice in choiceArray)
            {
                choice.SetActive(true);
            }

            foreach (GameObject destroyChoice in destroyChoiceArray)
            {
                Destroy(destroyChoice);
            }

            foreach (GameObject spawn in spawnObjects)
            {
                spawn.SetActive(true);
            }
        }
    }
}
