using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int score = 1;
    public void _AddScore(int score)
    {
        Score.Instance.AddScore(score);
    }
}
