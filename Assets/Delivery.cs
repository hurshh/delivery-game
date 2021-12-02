using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            Debug.Log("Package Picked up");
        }

        if (other.CompareTag("Boost"))
        {
            Debug.Log("Boost Activated");
        }
    }
}
