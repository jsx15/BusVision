using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    private GameObject propeller;

    public bool rotateProp;

    // Start is called before the first frame update
    void Start()
    {
        this.propeller = GameObject.Find("Propeller");
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateProp)
        {
            propeller.transform.Rotate(0, 0, 1000 * Time.deltaTime);
        }
    }
}