using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float second;
    public TMP_Text secondText;
    public GameObject lose;

    float currentTime;
    bool bRunTime = false, end = false;

    int wholenumber;

    public AudioSource audioSource;

    private void Update()
    {
        if(bRunTime && !end)
        {
            currentTime -= Time.deltaTime;
            secondText.text = Convert.ToInt32(currentTime).ToString();
            if(Convert.ToInt32(currentTime) == wholenumber )
            {
                //print("H");
                audioSource.Play();
                wholenumber--;
            }
            if(currentTime <0)
            {
                bRunTime = false;
                end = true;
                TimeFinished();
            }
        }
    }

    public void StartTimer(int time)
    {
        second = time;
        currentTime = time;
        bRunTime = true;
        end = false;

        wholenumber = time - 1;
    }
    public void StopTime()
    {
        bRunTime = false;
    }

    void TimeFinished()
    {
        lose.SetActive(true);
    }



}
