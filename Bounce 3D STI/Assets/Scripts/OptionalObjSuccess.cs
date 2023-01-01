using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionalObjSuccess : MonoBehaviour
{
    public GameObject optionalObj;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("PWD"))
        {
            optionalObj.SetActive(false);
            GameObject.Find("NPC-PWD-Female-BACOMM-BMMA").GetComponent<PWD>().enabled = false;
            //GameObject.Find("NPC-PWD-Female-BACOMM-BMMA").Pickable.layer = LayerMask.NameToLayer("Default");
        }
    }
}