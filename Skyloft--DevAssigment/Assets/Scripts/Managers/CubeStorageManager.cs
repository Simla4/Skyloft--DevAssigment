using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableSystem;

public class CubeStorageManager : MonoSingleton<CubeSpawnManager>
{
    [SerializeField] private ScriptableInt storageVal;

    public List<GameObject> storedObjects;

    
}
