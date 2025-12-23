using System;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    private int myInt = 0;
    public string myString = "The Strign Data";
    public float myFloat = 3.1459f;
    public bool myBool = true;
    // void Awake()
    // {
    //     Debug.Log(myString);
    // }
    // void Start()
    // {
    //     Debug.Log(myFloat);
    //     Debug.Log(myBool);
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     myInt++;
    //     Debug.Log(myInt);
    // }

    public void OnPointerEnter()
    {
        Debug.Log("OnPointer Enter called");
    }
    public void OnPointerExit()
    {
        Debug.Log("OnPointer Exit called");
    }
    public void OnpointerDown()
    {
        Debug.Log("OnPointer Down called");
    }
    public void OnPointerUp()
    {
        Debug.Log("OnPointer Up called");
    }
}
