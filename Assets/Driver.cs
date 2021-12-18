using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;


public class Driver : MonoBehaviour
{
    
    
    float moveSpeed = 10f;
    float fastSpeed = 20f;
    float slowSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = UnityEngine.Input.GetAxis("Horizontal")* Time.deltaTime*150;
        float steerSpeed = UnityEngine.Input.GetAxis("Vertical")* Time.deltaTime*moveSpeed;
        
        transform.Rotate(0, 0, steerAmount*-1);
        transform.Translate(0, steerSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boost") )
        {
            Debug.Log("Boost Activated");
            moveSpeed = fastSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
}