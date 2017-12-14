using UnityEngine;
using System.Collections;

public class MinimapInputManager : MonoBehaviour
{

    public float lookSpeed = 10;
    public float moveSpeed;
    private Vector3 curLoc;
    private Vector3 prevLoc;

    void Update()
    {
        InputListen();
        if (curLoc != prevLoc)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position - prevLoc), Time.fixedDeltaTime * lookSpeed);
    }

    private void InputListen()
    {
        prevLoc = curLoc;
        curLoc = transform.position;

        if (Input.GetKey(KeyCode.A))
            curLoc.z -= 1 * Time.fixedDeltaTime * moveSpeed;
        if (Input.GetKey(KeyCode.D))
            curLoc.z += 1 * Time.fixedDeltaTime * moveSpeed;
        if (Input.GetKey(KeyCode.W))
            curLoc.y += 1 * Time.fixedDeltaTime * moveSpeed;
        if (Input.GetKey(KeyCode.S))
            curLoc.y -= 1 * Time.fixedDeltaTime * moveSpeed;

        transform.position = curLoc;
    }
}