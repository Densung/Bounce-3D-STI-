using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSavedGame : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.DeleteKey("user");
        PlayerPrefs.DeleteKey("firstName");
        PlayerPrefs.DeleteKey("lastName");
        PlayerPrefs.DeleteKey("coursePosition");
        PlayerPrefs.DeleteKey("score_eval");
        PlayerPrefs.DeleteKey("state_eval");
        PlayerPrefs.DeleteKey("result_eval");
    }
}