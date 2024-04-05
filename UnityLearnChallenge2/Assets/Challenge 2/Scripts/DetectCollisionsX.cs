using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public static int point = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        point++;
        Debug.Log(point); 
    }   
}
