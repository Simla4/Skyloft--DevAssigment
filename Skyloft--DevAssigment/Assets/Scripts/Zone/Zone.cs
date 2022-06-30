using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableSystem;

public class Zone : MonoBehaviour
{
    public ScriptableInt valOfUnlock;

    public string zoneName;

    public bool isLock;

    private BoxCollider boxCollider;

    [SerializeField] private StackController stackController;
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider>();    
    }

    public IEnumerator IEUnlockTheZone(GameObject other)
    {

        for (int i = 0; i < valOfUnlock.GetValue(); i++)
        {
            if(stackController.stackList.Count <= 0) break;

            valOfUnlock.DecreaseValue(1);

            stackController.stackList.RemoveAt(0);
            Destroy(stackController.stackList[0]);


            yield return new WaitForSeconds(0.5f);

            if(valOfUnlock.GetValue() <= 0)
            {
                boxCollider.isTrigger = true;
            }
            Debug.Log(valOfUnlock.GetValue());
        }
    }
}
