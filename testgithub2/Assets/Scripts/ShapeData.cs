using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
[System.Serializable]
public class ShapeData : ScriptableObject
{
    [System.Serializable]
    public class Row
    {
        public int size=0;
        public bool[] columns;
        public Row() {}
        public Row(int _size)
        {
            size = _size;
            columns = new bool[size];
        }
        public void ClearRow()
        {
            for(int i=0; i< size; i++)
            {
                columns[i] = false;
            }
        }
    }
    public int rows;
    public int columns;
    public Row[] board;
    public void Clear()
    {
        for(int i=0; i<rows; i++)
        {
            board[i].ClearRow();
        }
    }
    public void ClearNewBoard()
    {
        board = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            board[i] = new Row(columns);
        }
    }
}
