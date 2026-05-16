using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI timerText; 
    float timer;
    bool isRunning;

    void Start()
    {
        timer = 0f;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString("F2");
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}