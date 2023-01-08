using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SampleTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI displayNumber;
    public TextMeshProUGUI displayPoints;
    public TextMeshProUGUI displayFinalScore;


    public static float number = 5;
    public static float points = 0;

    // Start is called before the first frame update
    void Start()
    {
        displayNumber.text = number.ToString();
        displayPoints.text = "Points: " + points;
        displayFinalScore.text = "Points: " + points;
    }

    private void Update()
    {
        displayNumber.text = number.ToString();
        displayPoints.text = "Points: " + points;
        displayFinalScore.text = "Points: " + points;
    }
}
