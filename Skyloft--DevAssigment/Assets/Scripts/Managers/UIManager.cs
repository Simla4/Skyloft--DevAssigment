using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ScriptableSystem;
public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentPlayerCube;
    [SerializeField] TextMeshProUGUI currentCubeZone0;
    [SerializeField] TextMeshProUGUI currentCubeZone1;
    [SerializeField] TextMeshProUGUI currentCubeZone2;
    [SerializeField] TextMeshProUGUI currentCubeZone3;
    [SerializeField] TextMeshProUGUI currentCubeZone4;
    [SerializeField] TextMeshProUGUI currentCubeZone5;
    [SerializeField] TextMeshProUGUI currentCubeZone6;
    [SerializeField] TextMeshProUGUI currentCubeZone7;

    [SerializeField] ScriptableInt zone0;
    [SerializeField] ScriptableInt zone1;
    [SerializeField] ScriptableInt zone2;
    [SerializeField] ScriptableInt zone3;
    [SerializeField] ScriptableInt zone4;
    [SerializeField] ScriptableInt zone5;
    [SerializeField] ScriptableInt zone6;
    [SerializeField] ScriptableInt zone7;

    [SerializeField] StackController stackController;

    // Update is called once per frame
    void Update()
    {
        currentPlayerCube.text = stackController.stackList.Count.ToString();

        currentCubeZone0.text = zone0.GetValue().ToString();
        currentCubeZone1.text = zone1.GetValue().ToString();
        currentCubeZone2.text = zone2.GetValue().ToString();
        currentCubeZone3.text = zone3.GetValue().ToString();
        currentCubeZone4.text = zone4.GetValue().ToString();
        currentCubeZone5.text = zone5.GetValue().ToString();
        currentCubeZone6.text = zone6.GetValue().ToString();
        currentCubeZone7.text = zone7.GetValue().ToString();
    }
}
