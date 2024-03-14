using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;


    private AnotherScript anotherScripts;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;


    private void Awake()
    {
        anotherScripts = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("Theplayer's score is " + anotherScripts.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " Times");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
