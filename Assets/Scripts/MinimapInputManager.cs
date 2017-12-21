using UnityEngine;
using System.Collections;

public class MinimapInputManager : MonoBehaviour
{
    private Vector3 prevloc;
    Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
        prevloc = player.transform.position;
    }

    void Update()
    {
        if (player)
        {
            transform.eulerAngles = new Vector3(0, 0, -player.eulerAngles.y);
        }
        var direction = player.transform.position - prevloc;
        transform.position += direction;
        prevloc = player.transform.position;
    }
}