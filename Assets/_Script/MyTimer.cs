using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    public TMP_Text timeText;
    float time;
    bool bTime = false;
    public bool bOnEnable = false;

    private void OnEnable()
    {
        if(bOnEnable)
        {
            bTime = true;
        }
    }

    private void Update()
    {
        if (bTime)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString();
        }
       
    }

    public void StopTime()
    {
        bTime = false;
    }
    public void StartTime()
    {
        bTime = true;
    }
    public void Reset()
    {
        time = 0;
        bTime = false;

    }

}
