using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            GetComponent<Light>().enabled = true;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f);
    }
}
