using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag.Equals("Ball"))
        {
            SampleTextUpdate.points += 1f;
            Destroy(gameObject);
        }
    }
}
