using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    public float minSpeed, maxSpeed;
    private Rigidbody Rb;
    private Vector3 newVelocity;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        newVelocity = new Vector3(Random.Range(minSpeed, maxSpeed), 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.velocity = newVelocity;
    }
}
