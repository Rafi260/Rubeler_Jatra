using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TSP_slot : MonoBehaviour, IDropHandler
{
    public TSP_manager gamemanager;
    public int id;
    public bool dropped = false;
    public bool forceMatch = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (dropped)
        {
            return;
        }
        //print("d");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<PuzzlePiece>().id == id)
            {
                //print("yes");
                gamemanager.Add(1);
            }
            else
            {
                //print("no");
                gamemanager.Add(0);
            }
            eventData.pointerDrag.GetComponent<PuzzlePiece>().placed = true;
            dropped = true;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
