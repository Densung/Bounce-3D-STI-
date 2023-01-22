using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject gameOverScreen;
    IEnumerator OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Ball"))
        {

            player.gameObject.GetComponent<TPController>().enabled = false;
            player.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(1);
            gameOverScreen.SetActive(true);

        }
    }
}
