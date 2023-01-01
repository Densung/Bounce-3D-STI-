using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoors : Interactable
{
    private bool isOpen = false;
    private bool canInteract = true;
    private Animator doorAnimation;

    private void Start()
    {
        doorAnimation = GetComponent<Animator>();
    }

    public override void OnFocus()
    {
        print("Looking at " + gameObject.name);
        getDescription();
    }

    public override void OnInteract()
    {
        if (canInteract)
        {
            isOpen = !isOpen;
            Vector3 doorTransformDirection = transform.TransformDirection(Vector3.forward);
            Vector3 playerTransformDirection = FirstPersonController.instance.transform.position - transform.position;
            float dot = Vector3.Dot(doorTransformDirection, playerTransformDirection);

            doorAnimation.SetFloat("dot", dot);
            doorAnimation.SetBool("isOpen", isOpen);

            //StartCoroutine(AutoClose());
        }
    }

    public override void OnLoseFocus()
    {
        print("Looked away from " + gameObject.name);
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

    /*private IEnumerator AutoClose()
    {
        while (isOpen)
        {
            yield return new WaitForSeconds(3);

            if(Vector3.Distance(transform.position, FirstPersonController.instance.transform.position) > 3)
            {
                isOpen = false;
                doorAnimation.SetFloat("dot", 0);
                doorAnimation.SetBool("isOpen", isOpen);
            }
        }
    }*/

    private void Animator_LockInteraction()
    {
        canInteract = false;
    }
    private void Animator_UnlockInteraction()
    {
        canInteract = true;
    }
}
