using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Do not destroy the car");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Passed through the line");    
    }
}
