using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObjects : Interactable
{
    public Material glow, nonglow;
    public bool isGlowing;

    public override void OnFocus()
    {
        print("Looking at " + gameObject.name);
        ToggleGlow();
        getDescription();

    }
    public override void OnInteract()
    {
        print("Interacted with " + gameObject.name);
        //Destroy(gameObject);
    }

    public override void OnLoseFocus()
    {
        print("Looked away from " + gameObject.name);
        ToggleNonGlow();
    }

    public override string getDescription()
    {
        return "Press [E] to Pickup/Drop";
    }

    public void ToggleGlow()
    {
        if (!isGlowing)
        {
            gameObject.GetComponent<MeshRenderer>().material = glow;
            isGlowing = true;
        }
    }
    public void ToggleNonGlow()
    {
        if (isGlowing)
        {
            gameObject.GetComponent<MeshRenderer>().material = nonglow;
            isGlowing = false;
        }
    }
}
