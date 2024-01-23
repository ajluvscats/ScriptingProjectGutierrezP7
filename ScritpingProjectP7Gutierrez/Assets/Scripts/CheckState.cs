using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject MyObjects;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + MyObjects.activeSelf);
        Debug.Log("Active in Hierarchy" + MyObjects.activeInHierarchy);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
