using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float acceleration = 20.0f;
    public Rigidbody m_rigidbody;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float mousex = 5 * Input.GetAxis("Mouse X");
        float mousey = 5 * -Input.GetAxis("Mouse Y");

        transform.Rotate(mousey, mousex, 0 );


        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        Vector3 vel = m_rigidbody.velocity;
        vel += transform.forward * forwardInput * acceleration * Time.deltaTime;
        vel += transform.right * horizontalInput * acceleration * Time.deltaTime;

        m_rigidbody.velocity = vel;
    }
}
