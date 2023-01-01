using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FailedText : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI state;
    public TextMeshProUGUI eval;

    public void UpdateText()
    {
        score.text = "0 Points";
        state.text = "N/A";
        eval.text = "You did not evacuate on time";
    }
}