using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBehaviour : MonoBehaviour
{
    public float springForceX;
    public float springForceY;
    public float springForceZ;
    
    private Rigidbody _rb;


    private void OnCollisionEnter(Collision col)
    {
        _rb = col.gameObject.GetComponent<Rigidbody>();
        Vector3 springForce = new Vector3(springForceX, springForceY, springForceZ);
        _rb.AddForce(springForce);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
