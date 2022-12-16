using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Add offset to camera position
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Follow the player's camera when position is changed
        transform.position = new Vector3(
            player.position.x + offset.x,
            offset.y,
            player.position.z + offset.z
        );
    }
}
