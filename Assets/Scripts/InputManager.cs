using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public float speed;
    private Vector3 _movement;
    private Vector3 moveDirection = Vector3.zero;

    public float rotationSpeed;


    public Transform target;
    void Update()
    {
        //_movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            //walk forward
            transform.position += speed * Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //walk backwards
            transform.position += speed * Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //walk left
            transform.position += speed * Vector3.left * Time.deltaTime;
            //transform.Rotate(0, -Time.deltaTime * rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //walk right
            transform.position += speed * Vector3.right * Time.deltaTime;
            //transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
        }


        /*Vector3 targetDir = target.position - transform.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        Debug.DrawRay(transform.position, newDir, Color.red);
        transform.rotation = Quaternion.LookRotation(newDir);*/
    }
}
