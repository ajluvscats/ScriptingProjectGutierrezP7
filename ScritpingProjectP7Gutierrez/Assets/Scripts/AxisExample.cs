using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;

    // Start is called before the first frame update
   




    // Update is called once per frame
    void Update()
    {

    float h = Input.GetAxis("Horizontal");
    float xPos = h * range;

    transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("Value Returned: " + h.ToString("F2"));

    }
}
