using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] public int debrisDam = 20;
    [SerializeField] public int lightDam = 5;
    [SerializeField] public int airconDam = 15;
    [SerializeField] public int shelfDam = 15;
    [SerializeField] public int metalDam = 40;


    [SerializeField]
    private LayerMask pickableLayerMask;

    [SerializeField]
    private Transform playerCameraTransform;

    [SerializeField]
    private GameObject pickUpUI;

    [SerializeField]
    [Min(1)]
    private float hitRange = 3;

    [SerializeField]
    private Transform pickUpParent;

    [SerializeField]
    private Transform pickUpHead;

    [SerializeField]
    private Transform pickUpPoint;

    [SerializeField]
    private Transform pickUpPWD;

    [SerializeField]
    public GameObject inHandItem;

    [SerializeField]
    private InputActionReference interactionInput, dropInput, useInput;

    private RaycastHit hit;

    /*public void AddHealth(int healthBoost)
    {
        Debug.Log($"Health boosted by {healthBoost}");
    }*/

    private void Start()
    {
        interactionInput.action.performed += Interact;
        dropInput.action.performed += Drop;
        useInput.action.performed += Use;
    }

    private void Use(InputAction.CallbackContext obj)
    {
        if (inHandItem != null)
        {
            IUsable usable = inHandItem.GetComponent<IUsable>();
            if (usable != null)
            {
                usable.Use(this.gameObject);
            }
        }
    }

    public void Drop(InputAction.CallbackContext obj)
    {
        playerOrigDamage();
        if (inHandItem != null)
        {
            MeshCollider mc = inHandItem.GetComponent<MeshCollider>();
            mc.enabled = true;
            inHandItem.transform.SetParent(null);
            inHandItem = null;
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
            }
        }
    }

    private void Interact(InputAction.CallbackContext obj)
    {
        if (hit.collider != null && inHandItem == null)
        {
            Debug.Log(hit.collider.name);
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
            if (hit.collider.GetComponent<Bandage>() || hit.collider.GetComponent<Antiseptic>()) //|| hit.collider.GetComponent<MedKit>())
            {
                Debug.Log("Health");
                inHandItem = hit.collider.gameObject;
                inHandItem.transform.position = Vector3.zero;
                inHandItem.transform.rotation = Quaternion.identity;
                inHandItem.transform.SetParent(pickUpParent.transform, false);
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
                return;
            }

            if (hit.collider.GetComponent<Item>())
            {
                Debug.Log("Book");
                bookDamage();
                inHandItem = hit.collider.gameObject;
                inHandItem.transform.position = Vector3.zero;
                inHandItem.transform.rotation = Quaternion.identity;
                inHandItem.transform.SetParent(pickUpHead.transform, false);
                MeshCollider mc = inHandItem.GetComponent<MeshCollider>();
                mc.enabled = false;
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
                return;
            }
            /*if (hit.collider.GetComponent<Debris>())
            {
                Debug.Log("Debris");
                inHandItem = hit.collider.gameObject;
                inHandItem.transform.position = Vector3.zero;
                inHandItem.transform.rotation = Quaternion.identity;
                inHandItem.transform.SetParent(pickUpPoint.transform, false);
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
                return;
            }*/
            if (hit.collider.GetComponent<PWD>())
            {
                Debug.Log("PWD");
                inHandItem = hit.collider.gameObject;
                inHandItem.transform.position = Vector3.zero;
                inHandItem.transform.rotation = Quaternion.identity;
                inHandItem.transform.SetParent(pickUpPWD.transform, false);
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
                return;
            }
        }
    }

    private void Update()
    {
        Debug.DrawRay(playerCameraTransform.position, playerCameraTransform.forward * hitRange, Color.red);
        if (hit.collider != null)
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);
            pickUpUI.SetActive(false);
        }

        if (inHandItem != null)
        {
            return;
        }

        if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out hit, hitRange, pickableLayerMask))
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(true);
            pickUpUI.SetActive(true);
        }
    }

    void playerOrigDamage()
    {
        debrisDam = 20;
        lightDam = 5;
        airconDam = 15;
        shelfDam = 15;
        metalDam = 40;
    }

    void bookDamage()
    {
        debrisDam = 10;
        lightDam = 3;
        airconDam = 8;
        shelfDam = 8;
        metalDam = 20;
    }
}