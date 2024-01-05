using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGame : MonoBehaviour
{
    int a;
    public GameObject win;
    public Timer timer;
    public GameObject[] btns;
    public GameObject[] texts;

    public void Add()
    {
        a++;
        if(a == 3)
        {
            win.SetActive(true);
            timer.StopTime();
        }
    }

    public void Reset()
    {
        foreach(GameObject go in btns)
        {
            go.SetActive(true);
        }
        foreach(GameObject go in texts)
        { go.SetActive(false); }

        a = 0;
    }
}
