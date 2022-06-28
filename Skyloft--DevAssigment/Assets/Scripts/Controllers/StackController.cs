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

        for(int i = 0; i < stackList.Count; i++)
        {
            stackList[i].transform.position = startPosition.position;

            yPos ++;
        }
    }
}
