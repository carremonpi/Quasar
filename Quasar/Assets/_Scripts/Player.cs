using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float y_vel;
    private bool jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(4, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        y_vel = rb.velocity.y;
        rb.velocity = new Vector3(4, y_vel, 0);

        if (Input.GetKeyDown(KeyCode.Space)) rb.velocity = new Vector3(4, 7, 0);
    }
}