using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputToMovement : MonoBehaviour
{
    public CharacterController Controller;
    public float Speed = .12f;
    public Transform PlayerObject;
    public float TurnSpeed = 2f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * y;

        Controller.Move(move * Speed);

        PlayerObject.Rotate(Vector3.up * x);

    }
}
