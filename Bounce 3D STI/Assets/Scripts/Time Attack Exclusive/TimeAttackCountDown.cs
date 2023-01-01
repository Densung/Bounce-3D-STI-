using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttackCountDown : FailedMenu
{
    public static int timeStart = 45;
    public bool startTimer;
    public Text countdowntext;
    public Text countdown;

    void Start()
    {
        countdowntext.enabled = false;
        countdown.enabled = false;
    }

    void Update()
    {
        if (startTimer == true)
        {
            countdowntext.enabled = true;
            countdown.enabled = true;
            countdown.text = timeStart.ToString();
        }
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            startTimer = true;

            while (startTimer == true)
            {
                yield return new WaitForSeconds(1);
                timeStart--;
                if (timeStart <= 0)
                {
                    Pause();
                }
            }
        }
    }
}
