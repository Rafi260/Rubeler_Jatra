using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TaskScedule02 : MonoBehaviour
{


    public Task[] tasks;
    bool currentTaskDone = false;
    public bool bOnEnable = false;

    float prevTime = 0;

    public GameObject objectToShow;

    int taskCount = 0;
    int currenTaskCount = 0;

    private void OnEnable()
    {
        taskCount = tasks.Length;
        if (bOnEnable)
            StartTask();
    }

    void StartTask()
    {
        currentTaskDone = true;
    }

    private void Update()
    {
        if (currentTaskDone && currenTaskCount < taskCount)
        {

            currentTaskDone = false;
            StartCoroutine(Task(tasks[currenTaskCount].objToShow, tasks[currenTaskCount].hides, tasks[currenTaskCount].timer - prevTime));
            prevTime = tasks[currenTaskCount].timer;
        }
    }

    IEnumerator Task(GameObject go, GameObject[] goH, float time)
    {
        yield return new WaitForSeconds(time);
        if (goH != null)
        {
            foreach (var a in goH)
            {
                a.SetActive(false);
            }
        }

        go.SetActive(true);
        currenTaskCount++;
        currentTaskDone = true;
        if (currenTaskCount >= taskCount && objectToShow!= null)
        {

            objectToShow.SetActive(true);
        }

    }

    public void Reset()
    {
        taskCount = tasks.Length;
        currenTaskCount = 0;
        prevTime = 0;
        StartTask();
    }
}
