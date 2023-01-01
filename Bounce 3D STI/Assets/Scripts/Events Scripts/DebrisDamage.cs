using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisDamage : MonoBehaviour
{
    Player player = new Player();

    public AudioSource[] sounds;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (gameObject.tag.Equals("Debris"))
            {
                FirstPersonController.OnTakeDamage(player.debrisDam);
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Lights"))
            {
                FirstPersonController.OnTakeDamage(player.lightDam);
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Aircon"))
            {
                FirstPersonController.OnTakeDamage(player.airconDam);
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Shelves"))
            {
                FirstPersonController.OnTakeDamage(player.shelfDam);
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Metal"))
            {
                FirstPersonController.OnTakeDamage(player.metalDam);
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
        }

        /*if (col.gameObject.tag.Equals("Book"))
        {
            if (gameObject.tag.Equals("Debris"))
            {
                foreach (AudioSource sound in sounds)
                {
                    FirstPersonController.OnTakeDamage(10);
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Lights"))
            {
                foreach (AudioSource sound in sounds)
                {
                    FirstPersonController.OnTakeDamage(3);
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Aircon"))
            {
                foreach (AudioSource sound in sounds)
                {
                    FirstPersonController.OnTakeDamage(8);
                    sound.Play();
                }
            }
        }
        */
        if (col.gameObject.tag.Equals("Floors"))
        {
            if (gameObject.tag.Equals("Debris"))
            {
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Lights"))
            {
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Aircon"))
            {
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
            if (gameObject.tag.Equals("Shelves"))
            {
                foreach (AudioSource sound in sounds)
                {
                    sound.Play();
                }
            }
        }
    }
}
