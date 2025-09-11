using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform board;
    public GameObject slotPrefab;
    void Start()
    {
        SetUp();
    }

    public void SetUp()
    {
        for(int i=0; i<8; i++)
        {
            for(int j=0; j <4; j++)
            {
                GameObject obj = Instantiate(slotPrefab, board);
                obj.GetComponent<SlotController>().index = new int[] {i,j};
            }
        }
    }
}
