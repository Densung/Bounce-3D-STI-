using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableChoices_InviWall : Interactable
{
    public GameObject Object, spawnInvWall1, spawnInvWall2, spawnInvWall3;

    public GameObject[] playerChoice;
    private void Start()
    {
        Object.SetActive(false);
    }
    public override void OnFocus()
    {
        print("Looking at " + gameObject.name);
        Object.SetActive(true);
        //ToggleGlow();
        //getDescription();
    }
    public override void OnInteract()
    {
        print("Interacted with " + gameObject.name);
        Destroy(gameObject);
        spawnInvWall1.SetActive(true);
        spawnInvWall2.SetActive(true);
        spawnInvWall3.SetActive(true);
        
        foreach (GameObject choice in playerChoice)
        {
            choice.SetActive(true);
        }
    }

    public override void OnLoseFocus()
    {
        print("Looked away from " + gameObject.name);
        //ToggleNonGlow();
        Object.SetActive(false);
    }

    public override string getDescription()
    {
        return "[E] Proceed";
    }
}