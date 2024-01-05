using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public static Score Instance;
    public GameObject star;

    private void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddScore(int a)
    {
        score += a;
        //print(score);
    }

    void StarAnim()
    {
        star.transform.DORotate(new Vector2(0, 360), 1);
    }

}
