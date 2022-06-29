using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Transform startPosition;

    public List<GameObject> stackList;
    [SerializeField] private int columnCountLimit = 3, rowCountLimit = 10;

    private int columnCounter = 0, rowCounter = 0;

    public void StackPosition()
    {
        var yPos = startPosition.position.y;
        var xPos = startPosition.position.x;
        var stackCount = stackList.Count;

        for(int i = 0; i < stackCount; i++)
        {
            var stackXPos = stackList[i].transform.position.x;
            var stackYPos = stackList[i].transform.position.y;

            if(i % 3 == 0)
            {
                stackList[i].transform.position = startPosition.position;
            }
            else if(i % 3 == 1)
            {
                
            }
        }
    }
}
