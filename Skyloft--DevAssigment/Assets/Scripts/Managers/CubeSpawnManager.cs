using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnManager : MonoSingleton<CubeSpawnManager>
{
    public List<GameObject> spawnedCube;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float waitingTime = 3f;
    [SerializeField] private int spawnVal = 10;

    private Coroutine cubeSpawner;
 
    private void Update()
    {
        if (spawnedCube.Count == 0)
        {
            cubeSpawner =  StartCoroutine(IECubeSpawner());
        }
    }

    private IEnumerator IECubeSpawner()
    {
        var yPos = gameObject.transform.position.y;


        for (int i = 0; i < spawnVal; i++)
        {
            var cube = Instantiate(objectToSpawn, new Vector3(gameObject.transform.position.x, 
                                                              yPos, gameObject.transform.position.z), 
                                                              Quaternion.identity);

            yPos ++;

            spawnedCube.Add(cube);
            yield return new WaitForSeconds(waitingTime);
        }

        Debug.Log("Tekrar doldu");
    }
}
