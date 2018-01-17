using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [Header("Movement and RigidBody")]
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float MovementSpeed;
  
    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        //Rechts
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(MovementSpeed, rb.velocity.y);

        }
        //Links
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-MovementSpeed, rb.velocity.y);
        }
        //Achteruit
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(-MovementSpeed, rb.velocity.z);
        }
        //Vooruit
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(+MovementSpeed, rb.velocity.z);
        }
    }
}
