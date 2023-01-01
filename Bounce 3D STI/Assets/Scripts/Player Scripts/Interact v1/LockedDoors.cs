using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoors : Interactable
{
    private bool isOpen = false;
    private bool canInteract = true;
    public GameObject lockDoor;
    public AudioSource[] lockedSFXArray;

    public override void OnFocus()
    {
        print("Looking at " + gameObject.name);
    }

    public override void OnInteract()
    {
        if (canInteract)
        {
            lockDoor.SetActive(true);
            foreach (AudioSource lockedSFX in lockedSFXArray)
            {
                lockedSFX.Play();
            }
        }
    }

    public override void OnLoseFocus()
    {
        print("Looked away from " + gameObject.name);
        lockDoor.SetActive(false);
    }

    public override string getDescription()
    {
        if (isOpen == true)
        {
            return "[E] Close Door";
        }
        else
        {
            return "[E] Open Door";
        }
    }
}
