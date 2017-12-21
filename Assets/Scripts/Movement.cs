using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private float y = 0f;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime;
        var z = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Rotate(0, x, 0);
        transform.Translate(0, y, z);
    }
}
