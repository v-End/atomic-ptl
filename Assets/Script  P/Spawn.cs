using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
     public GameObject objectToSpawn;
     public int objectCount;
     public int yPosition;
     public int Distance;
 
     void Start()
     {
 
         objectCount = 1;
         yPosition = 0;
         Distance = 2;
 
         for (int i = 0; i < objectCount; i++)
         {
             Instantiate(objectToSpawn, new Vector2(0, yPosition), Quaternion.identity);
             yPosition += Distance;
         }
     }
}
