using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ShakeTrigger : MonoBehaviour
{
    /* Code for CameraShake
    public CameraShake cameraShake;

    void Start()
    {
        cameraShake = GameObject.Find("Main Camera").GetComponent<CameraShake>();
    }*/

    public GameObject libraryWall;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals ("Player"))
        {
            // Start CameraShake
            //StartCoroutine(cameraShake.Shake(10f, 0.2f));

            // Start EZCameraShake
            CameraShaker.Instance.ShakeOnce(2f, 4f, 20f, 20f);
            Destroy(libraryWall);
            Destroy(gameObject);
        }
    }
}