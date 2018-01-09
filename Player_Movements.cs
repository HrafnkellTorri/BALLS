using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour {

        public Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeRotationX;
    }
        void FixedUpdate()
        {
            float x,z;


            x = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
            z = Input.GetAxis("Vertical") * Time.deltaTime * 5;

            

            if(Physics.Raycast(transform.position,new Vector3(0, -1), 0.6f))
            {
            Debug.Log("HIT!");
                if (Input.GetButtonDown("Jump"))
                {
                    rb.velocity = new Vector3(0, 4, 0);
                }
                else
                {

                }
            }

            rb.AddTorque(z, -1000, x * Time.deltaTime);


        // rb.freezeRotation = true;
    }
    }
