using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler 
{
    [SerializeField] private RectTransform joystickBase, joystickTip;
    
    public Vector2 joystickDirection;

    // Start is called before the first frame update
    void Start()
    {
         DisableJoystick();
    }

    public void EnableJoystick()
    {
        joystickBase.gameObject.SetActive(true);
        joystickDirection = Vector2.zero;
    }

    public void DisableJoystick()
    {
        joystickBase.gameObject.SetActive(false);
        joystickTip.position = joystickBase.position;

        joystickDirection = Vector2.zero;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        joystickBase.position = eventData.position;

        EnableJoystick();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        DisableJoystick();
    }

    public void OnDrag(PointerEventData eventData)
    {
        joystickTip.position = eventData.position;

        var tipOffset = Vector3.ClampMagnitude((joystickTip.position - joystickBase.position), 70f);
        joystickDirection = tipOffset / 70f;

        joystickTip.position = joystickBase.position + tipOffset;
    }
}
