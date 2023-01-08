using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SampleDepleteHealth : MonoBehaviour
{
    public GameObject gameOverScreen;
    IEnumerator OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag.Equals("Ball"))
        {
            SampleTextUpdate.number -= 1f;
            if (SampleTextUpdate.number > 0)
            {
                player.gameObject.GetComponent<TPController>().enabled = false;
                player.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
                yield return new WaitForSeconds(1);
                player.gameObject.GetComponent<TPController>().enabled = true;
                player.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
                player.gameObject.transform.position = TPController.spawnPoint;
                
            }

            else if (SampleTextUpdate.number == 0)
            {
                gameOverScreen.SetActive(true);
            }
        }
    }
}
