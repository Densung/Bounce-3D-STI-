using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public int addSeconds = 10;
    public GameObject clockIcon;
    public AudioSource addSecondsSFX;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            TimeAttackCountDown.timeStart += addSeconds;

            addSecondsSFX.Play();

            Destroy(clockIcon);

        }
    }
}