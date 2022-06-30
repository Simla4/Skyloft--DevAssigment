using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var zone = other.gameObject.GetComponent<Zone>();

        if(other.gameObject.CompareTag("Zone"))
        {
            if(zone.isLock == false)
            {
                StartCoroutine(zone.IEUnlockTheZone(other.gameObject));
            }
        }
    }
}

