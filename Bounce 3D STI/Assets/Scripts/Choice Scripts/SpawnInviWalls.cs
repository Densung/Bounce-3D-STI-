using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInviWalls : Interactable
{
    public GameObject Object;
    private void Start()
    {
        Object.SetActive(false);
    }
    public override void OnFocus()
    {
        print("Looking at " + gameObject.name);
        Object.SetActive(true);
        //ToggleGlow();
        getDescription();

    }
    public override void OnInteract()
    {
    }
    public override void OnLoseFocus()
    {
        print("Looked away from " + gameObject.name);
        //ToggleNonGlow();
        Object.SetActive(false);
    }

    public override string getDescription()
    {
        return "";
    }
}
