using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour


{
    // Start is called before the first frame update
    private Rigidbody rb;

    private void Awake()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
