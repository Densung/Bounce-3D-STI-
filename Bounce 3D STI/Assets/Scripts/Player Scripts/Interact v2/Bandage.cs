using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bandage : MonoBehaviour, IUsable
{
    public UnityEvent OnUse => throw new System.NotImplementedException();

    public void Use(GameObject actor)
    {
        FirstPersonController.OnTakeHeal(10);
        Destroy(gameObject);
    }
}