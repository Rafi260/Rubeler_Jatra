using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shout : MonoBehaviour
{
    public GameObject mic;

    public Transform[] pos;

    public float time;
    float currentTime;

    public TMP_Text click;

    public AudioSource source;

    public GameObject image, win;
    public Timer timer;
    

    public int totalTimeToClick = 5;
    int currentClick = 0;
    private void Start()
    {
        currentTime = time;
        
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0 && currentClick <= totalTimeToClick)
        {
            int a = Random.Range(0, pos.Length);
            mic.transform.position = pos[a].position;
            currentTime = time;
        }
    }

    public void Click()
    {
        image.SetActive(true);
        Invoke("HideImage", .3f);
        print("H");
        currentClick++;
        source.Play();
        click.text = currentClick.ToString();
        if (currentClick == totalTimeToClick)
        {
            Invoke("Hide", 1);
        }


    }

    void Hide()
    {
        gameObject.SetActive(false);
        win.SetActive(true) ;
        timer.StopTime();
    }

    void HideImage()
    {
        image.SetActive(false);
    }

    public void Reset()
    {
        currentClick = 0;
    }




}
