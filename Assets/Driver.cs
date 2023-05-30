using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringSpeed = 0.1f;
    [SerializeField] float movingSpeed = 0.01f;
    
    void Start()
    {

    }

    
    void Update()
    {
        float steeringAmount = Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime;
        float movingAmount = Input.GetAxis("Vertical") * movingSpeed * Time.deltaTime;
        transform.Translate(0, movingAmount, 0);
        transform.Rotate(0, 0, -steeringAmount);
    }
}
