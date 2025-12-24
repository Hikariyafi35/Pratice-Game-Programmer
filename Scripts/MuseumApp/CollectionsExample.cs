using System;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsExample : MonoBehaviour
{
   private int[] demoArray;
   private List<string> demoList;
   private Dictionary<int, string> demoDictionary;

   private void Start()
   {
      demoArray = new int[3];
      demoArray[0] = 10;
      demoArray[1] = 11;
      demoArray[2] = 20;
      int sum = demoArray[0] + demoArray[1] + demoArray[2];
      Debug.Log(sum);

      demoList = new List<string>();
      demoList.Add("Hello");
      demoList.Add("World");
      demoList.Add("!");
      Debug.Log(demoList[0] + " " + demoList[1] + demoList[2]);

      demoDictionary = new Dictionary<int, string>();
      demoDictionary[demoArray[0]] = demoList[0];
      Debug.Log(demoDictionary[10]);

   }
}
