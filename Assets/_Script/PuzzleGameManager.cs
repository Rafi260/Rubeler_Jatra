using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PuzzleGameManager : MonoBehaviour
{
    public GameObject win, lose;
    public int puzzleSize;
    int[,] states;

    public PuzzlePiece[] puzzlePieces;
    public PuzzleSlot[] slots;
    Vector2[] piecePos;

    public Timer timer;


    private void Start()
    {
        states = new int[puzzleSize, 2];
        piecePos = new Vector2[puzzleSize];

        for (int i = 0; i < puzzleSize; i++)
        {
            piecePos[i] = puzzlePieces[i].transform.position;
            states[i, 1] = -1;
        }
    }

    public void ChabgeState(int slot, int state)
    {
        if (slot >= puzzleSize)
        {
            lose.SetActive(true);

        }
        else
        {
            states[slot, 1] = state;
            print("a");
            Check();
        }

    }

    void Check()
    {
        int finish = 1;
        int correct = 1;
        for (int i = 0; i < puzzleSize; i++)
        {

            if (states[i, 1] == -1)
            {
                finish = 0; break;
            }
            if (states[i, 1] == 0)
            {
                if (correct == 1)
                {
                    correct = 0;
                }
            }

        }
        if (finish == 1)
        {
            print("finished");
            if (correct == 1)
            {
                print("win");
                win.gameObject.SetActive(true);
                if (timer) timer.StopTime();

            }
            else
            {
                print("lose");
                lose.gameObject.SetActive(true);
                if(timer)timer.StopTime();
            }
        }

    }

    public void Reset()
    {
        for (int i = 0; i < puzzleSize; i++)
        {
            puzzlePieces[i].transform.position = piecePos[i];
            puzzlePieces[i].placed = false;
            puzzlePieces[i].GetComponent<CanvasGroup>().blocksRaycasts = true;
            slots[i].dropped = false;
            states[i, 1] = -1;
        }

    }
}
