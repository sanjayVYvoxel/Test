using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPrograming : MonoBehaviour
{

    public int Int = 50;
    public float Float = 0.7f;
    public string String = "name";
    public bool Bool = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

        Debug.Log("Int value is " + Int);
        Debug.Log("Float value is "+Float);
        Debug.Log("String value is "+ String);
        Debug.Log("Bool Value is " + Bool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
