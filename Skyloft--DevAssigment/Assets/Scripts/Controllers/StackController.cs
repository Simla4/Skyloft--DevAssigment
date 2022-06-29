using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Transform startPosition;

    public List<GameObject> stackList;
    public int columnCountLimit = 3, rowCountLimit = 10;

    private int columnCounter = 0;

    public void StackPosition()
    {
        var yPos = startPosition.position.y;
        var xPos = startPosition.position.x;
        var zPos = startPosition.position.z;
        var stackCount = stackList.Count;

        for(int i = 0; i < stackCount; i++)
        {
            columnCounter ++;

            stackList[i].transform.position = new Vector3(xPos, yPos, zPos);

            xPos --;

            if(columnCounter >= columnCountLimit)
            {
                columnCounter = 0;
                xPos = 1;
                yPos ++;
            }

            Debug.Log("Column Counter: " + columnCounter + "x Pos: " + xPos);
            
        }
    }
}
