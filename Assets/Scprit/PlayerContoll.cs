using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContoll : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;
    private Vector2 movementValue;


    void Update()
    {
        MovementSystem();
    }

    void Move(Vector3 position)
    {
        transform.position += position * (movementSpeed * Time.deltaTime);
    }

    void MovementSystem()
    {
        Move(new Vector3 (movementValue.x, 0, movementValue.y));
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>();
    }




}

