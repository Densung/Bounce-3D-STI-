using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Aftershock1 : MonoBehaviour
{
    /* Code for CameraShake
    public CameraShake cameraShake;

    void Start()
    {
        cameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
    }*/
    public GameObject trigger1, trigger2;
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals ("Player"))
        {
            // Start CameraShake
            //StartCoroutine(cameraShake.Shake(10f, 0.2f));

            // Start EZCameraShake
            CameraShaker.Instance.ShakeOnce(2f, 4f, 20f, 20f);
            Destroy(gameObject);
            Destroy(trigger1);
            Destroy(trigger2);
        }
    }
}