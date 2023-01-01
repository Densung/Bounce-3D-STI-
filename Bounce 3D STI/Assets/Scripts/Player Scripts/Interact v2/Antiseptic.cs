using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Antiseptic : MonoBehaviour, IUsable
{
    public UnityEvent OnUse => throw new System.NotImplementedException();

    public void Use(GameObject actor)
    {
        FirstPersonController.OnTakeHeal(15);
        Destroy(gameObject);
    }
}
