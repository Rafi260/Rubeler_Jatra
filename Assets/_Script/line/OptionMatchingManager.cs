using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OptionMatchingManager : MonoBehaviour
{
    public UiMatchOption[] leftMatchOption = null;
    public UiMatchOption[] allMatchOption = null;
    public string[] correctmatchIntex;
    public int correctAnswer = 0;
    public UnityEvent OnMatchingComplete;
    public void CheckIfAllOptionConnected()
    {
        correctAnswer = 0;
        for (int i = 0; i < leftMatchOption.Length; i++)
        {
            if (leftMatchOption[i].isConnected == true)
            {
                string matchIntex = leftMatchOption[i].optionIndex.ToString() + leftMatchOption[i].connectedOptionIndex.ToString();
                if (matchIntex == correctmatchIntex[i])
                {
                    correctAnswer++;
                    if (i == leftMatchOption.Length - 1)
                    {
                        OnMatchingComplete?.Invoke();
                    }
                }
                if (i == leftMatchOption.Length - 1)
                {
                    OnMatchingComplete?.Invoke();
                }
                continue;
            }
            else
            {
                break;
            }
        }
    }

    public void MatchLine(bool setTo)
    {
        for (int i = 0; i < allMatchOption.Length; i++)
        {
            allMatchOption[i].lineRenderer.enabled = setTo;
        }
    }

    public void Reset()
    {
        foreach(var option in allMatchOption)
        {
            option.Reset();
        }
    }
}
