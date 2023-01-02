using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SampleTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI displayNumber;

    public static float number = 5;

    // Start is called before the first frame update
    void Start()
    {
        displayNumber.text = number.ToString();
    }

    private void Update()
    {
        displayNumber.text = number.ToString();
    }
}
