using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnManager : MonoSingleton<CubeSpawnManager>
{
    public List<GameObject> spawnedCube;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float waitingTime = 3f;

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

        for (int i = 0; i < 10; i++)
        {
            var cube = Instantiate(objectToSpawn, gameObject.transform.position, Quaternion.identity);
            spawnedCube.Add(cube);
            yield return new WaitForSeconds(3);
        }

        Debug.Log("Tekrar doldu");
    }
}
