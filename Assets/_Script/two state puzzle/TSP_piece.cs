using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TSP_piece : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public Canvas canvas;
    CanvasGroup canvasGroup;
    public int id;
    public bool placed = false;

    Vector2 initialPos;

    private void Start()
    {
        initialPos = gameObject.transform.position;
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }



    public void OnBeginDrag(PointerEventData eventData)
    {
        print("gg");
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!placed)
        {
            float a = canvas ? canvas.scaleFactor : 1;
            rectTransform.anchoredPosition += eventData.delta / a;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        if (!placed)
        {
            rectTransform.position = initialPos;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
