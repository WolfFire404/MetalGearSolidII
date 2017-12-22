using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 movement;
    private Rigidbody rigidBody;

    private float x;
    private float z;
    private float speed = 8;
    private float moveHorizontal = 0;
    private float moveVertical = 0;

    private Vector3 previousMovement = Vector3.zero;
    public Vector3 eulerAngleVelocity;



    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Movement()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(previousMovement), 0.2F);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        if (!(movement.x == 0 && movement.z == 0))
        {
            previousMovement = movement;
        }

    }

    void FixedUpdate()
    {
        Movement();
    }
}
