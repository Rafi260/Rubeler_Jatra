using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleSlot : MonoBehaviour, IDropHandler
{
    public PuzzleGameManager gamemanager;
    public int id;
    public bool dropped = false;
    public bool forceMatch = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (dropped)
        {
            return;
        }
        
        if (eventData.pointerDrag != null)
        {

            if (eventData.pointerDrag.GetComponent<PuzzlePiece>().id == id)
            {
                print("dropped");
                if (gamemanager) gamemanager.ChabgeState(id, 1);


            }
            else
            {
                if (forceMatch)
                {
                    return;
                }

                if (gamemanager) gamemanager.ChabgeState(id, 0);
            }
            eventData.pointerDrag.GetComponent<PuzzlePiece>().placed = true;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = gameObject.GetComponent<RectTransform>().anchoredPosition;
            dropped = true;
            
        }
    }
}
