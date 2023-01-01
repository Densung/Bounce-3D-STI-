using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXTrigger : MonoBehaviour
{
    public AudioSource[] sounds, pauseSounds;
    public GameObject[] destroyObject;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            foreach (AudioSource sound in sounds)
            {
                sound.Play();
            }
        }

        if (col.gameObject.tag.Equals("Player"))
        {
            foreach (AudioSource sound in pauseSounds)
            {
                sound.Pause();
            }
        }

        foreach (GameObject sfx in destroyObject)
        {
            Destroy(sfx);
        }
    }
}
