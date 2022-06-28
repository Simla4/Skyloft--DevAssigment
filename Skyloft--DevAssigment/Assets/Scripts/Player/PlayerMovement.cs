using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private JoystickController joystickController;

    [SerializeField] private float speed;

    private Vector2 joystickDirection => joystickController.joystickDirection;

    // Update is called once per frame
    void Update()
    {
        var worldDirection = new Vector3(joystickDirection.x, 0, joystickDirection.y);

        transform.position += worldDirection * speed * Time.deltaTime;

        //transform.rotation = Quaternion.Euler(0, joystickDirection.y * 360, 0);
    }
}
