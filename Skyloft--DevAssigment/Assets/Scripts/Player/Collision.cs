using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] StackController stackController;
    
    private void OnTriggerEnter(Collider other)
    {
        var spawnedCube = CubeSpawnManager.Instance.spawnedCube;
        var spawnedCubeCount = CubeSpawnManager.Instance.spawnedCube.Count;

        if(other.gameObject.CompareTag("Cube"))
        {
            for (int i = 0; i < spawnedCubeCount; i++)
            {
                if(stackController.stackList.Count < stackController.columnCountLimit * stackController.rowCountLimit)
                {
                    stackController.stackList.Add(spawnedCube[0]);

                    spawnedCube[0].transform.parent = transform;

                    spawnedCube.RemoveAt(0);

                    stackController.StackPosition();
                }
            }
            
        }
    }
}
