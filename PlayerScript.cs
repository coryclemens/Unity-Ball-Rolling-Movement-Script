using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public Transform trn;
    public float rot = 1;
    public float rotDeg;
    public float rotSpeed = 1;
    public float x;
    public float z;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trn = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Mathf.Cos(rotDeg * Mathf.PI / 180);
        z = Mathf.Sin(rotDeg * Mathf.PI / 180);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddTorque(x, 0, z, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddTorque(-x, 0, -z, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotDeg += rotSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotDeg -= rotSpeed;

        }
    }
}
