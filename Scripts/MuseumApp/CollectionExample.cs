using System.Collections.Generic;
using UnityEngine;

public class CollectionExample : MonoBehaviour
{
    private int[] demoArray;
    private List<string> demoList;

    private void Start() {
        demoArray = new int[4];
        demoArray[0] = 10;
        demoArray[1] = 20;
        demoArray[2] = 30;
        demoArray[3] = 40;
        Debug.Log(demoArray[2]);
        int sum = demoArray[0] + demoArray[1] + demoArray[2];
        Debug.Log("Sum: " + sum);

        demoList = new List<string>();
        demoList.Add("Hello");
        demoList.Add("World");
        demoList.Add("!");
        Debug.Log(demoList[0] + " " + demoList[1] + " " + demoList[2]);
    }
}
