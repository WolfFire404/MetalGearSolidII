using UnityEngine;
using System.Collections;

public class BlackBars : MonoBehaviour
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
        var direction = player.transform.position - prevloc;
        direction = new Vector3(direction.x, direction.z, 0);
        transform.position += direction / 2;
        prevloc = player.transform.position;
    }
}