using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class setCom : MonoBehaviour
{
    public GameObject com;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
