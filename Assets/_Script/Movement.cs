using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    public Vector2 movePos;
    public float transitionTime, delayTime;
    public bool bLoop, x,y;
    public bool playOnEnable;

    private void OnEnable()
    {
        if (playOnEnable)
        {
            Move();
        }

    }

    public void MoveOneDirection()
    {
        gameObject.transform.DOMoveX(movePos.x, transitionTime).SetLoops(-1, LoopType.Yoyo);
    }

    public void Move()
    {
        if (bLoop)
        {
            if(x)
            {
                gameObject.transform.DOMoveX(movePos.x, transitionTime).SetLoops(-1, LoopType.Yoyo);

            }
            else if(y)
            {
                gameObject.transform.DOMoveY(movePos.y, transitionTime).SetLoops(-1, LoopType.Yoyo);

            }
            else
            {
                gameObject.transform.DOLocalMove(movePos, transitionTime).SetLoops(-1, LoopType.Yoyo);

            }
        }
        else
        {
            if (x)
            {
                gameObject.transform.DOMoveX(movePos.x, transitionTime).SetDelay(delayTime);

            }
            else if (y)
            {
                gameObject.transform.DOMoveY(movePos.y, transitionTime).SetDelay(delayTime);

            }
            else
            {
                gameObject.transform.DOLocalMove(movePos, transitionTime).SetDelay(delayTime);

            }
        }
    }
}
