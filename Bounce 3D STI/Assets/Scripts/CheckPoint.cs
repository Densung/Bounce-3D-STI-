using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject checkpointPos;

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag.Equals("Ball"))
        {
            TPController.spawnPoint = checkpointPos.transform.position;
            Debug.Log("Checkpoint Saved!");
            Destroy(gameObject);
        }
    }
}
