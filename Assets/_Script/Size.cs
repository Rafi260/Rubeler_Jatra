using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    public Vector2 scale;
    public float transitionTime, delayTime;
    public bool bLoop;
    public bool playOnEnable;
    private void Start()
    {
        BeatSize();
    }

    private void OnEnable()
    {
        if (playOnEnable)
        {
            BeatSize();
        }
    }
    void BeatSize()
    {
        if (bLoop)
        {
            gameObject.transform.DOScale(scale, transitionTime).SetLoops(-1, LoopType.Restart);

        }
        else
        {
            gameObject.transform.DOScale(scale, transitionTime).SetDelay(delayTime);

        }
    }
}
