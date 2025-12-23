using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{
    private List<string> absenList;
    private void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            Debug.Log("Iteration: " + i);
        }
        absenList = new List<string>();
        absenList.Add("Alice");
        absenList.Add("Bob");
        absenList.Add("Charlie");
        absenList.Add("Diana");

        foreach(string nama in absenList)
        {
            Debug.Log(nama);
        }
    }
}
