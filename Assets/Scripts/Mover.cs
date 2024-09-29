using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Speed { get; set; }
    private Vector3 _inputVector;

    private string _horizontalAxisName = "Horizontal";
    private string _verticalAxisName = "Vertical";

    public void Initialize(float speed)
    {
        Speed = speed;
    }

    private void Update()
    {
        HandleMoveDirection();
    }

    private void HandleMoveDirection()
    {
        float horizontal = Input.GetAxisRaw(_horizontalAxisName);
        float vertical = Input.GetAxisRaw(_verticalAxisName);

        _inputVector = new Vector3(horizontal,0,vertical).normalized;
    }

    public void Move(CharacterController characterController)
    {
        characterController.Move(_inputVector * Time.deltaTime * Speed);
    }
}
