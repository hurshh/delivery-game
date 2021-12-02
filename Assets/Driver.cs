using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Driver : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = UnityEngine.Input.GetAxis("Horizontal")* Time.deltaTime*150;
        float steerSpeed = UnityEngine.Input.GetAxis("Vertical")* Time.deltaTime*10;
        
        transform.Rotate(0, 0, steerAmount*-1);
        transform.Translate(0, steerSpeed, 0);
    }
    
}