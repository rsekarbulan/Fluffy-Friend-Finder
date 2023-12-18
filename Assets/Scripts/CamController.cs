using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform cam;

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, cam.position.y, transform.position.z);
    }
}
