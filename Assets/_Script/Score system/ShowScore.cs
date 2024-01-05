using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    TMP_Text scoretext;
    private void Start()
    {
        scoretext =  GetComponent<TMP_Text>();
    }

    private void Update()
    {
        scoretext.text = Score.Instance.score.ToString();
    }
}
