using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSP_manager : MonoBehaviour
{
    public int puzzleSize;
    int[] checkList;
    int currentIndex = 0;

    public GameObject win, lose;

    public List<PuzzlePiece> pieceList;
    public List<TSP_slot> slots;
    Vector2[] piecePos;



    public Timer timer;
    private void Start()
    {

        piecePos = new Vector2[puzzleSize];
        checkList = new int[puzzleSize];

        for(int i = 0; i < checkList.Length; i++)
        {
            piecePos[i] = pieceList[i].transform.position;
            checkList[i] = -1;
        }
    }

    public void Add(int a)
    {
        checkList[currentIndex] = a;
        currentIndex++;
        if(currentIndex >= puzzleSize) 
        {
            Check();
        }
    }

    void Check()
    {
        int w = 1;
        for(int i = 0; i < checkList.Length; i++)
        {
            print(checkList[i]);
            if (checkList[i] == 0)
            {
                
                w = 0; break;
            }
        }
        if(w == 1)
        {
            win.SetActive(true);
            if (timer) timer.StopTime();
        }
        else
        {
            lose.SetActive(true);
            if (timer) timer.StopTime();
        }
    }

    public void Reset()
    {
        currentIndex = 0;
        foreach(var  piece in pieceList)
        {
            piece.placed = false;
            piece.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        for (int i = 0; i < checkList.Length; i++)
        {
            pieceList[i].transform.position = piecePos[i];
            checkList[i] = -1;
        }
        foreach (var slot in slots)
        {
            slot.dropped = false;
        }

        for (int i = 0; i < checkList.Length; i++)
        {
            checkList[i] = -1;
        }
    }
}
