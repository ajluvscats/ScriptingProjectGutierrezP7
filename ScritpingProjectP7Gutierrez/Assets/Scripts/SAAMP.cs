using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAAMP : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AC myOtherClass;


    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AC();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
   
   
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
