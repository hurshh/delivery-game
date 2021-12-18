using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 1);
    [SerializeField] Color32 NoPackageColor = new Color32(255, 255, 255, 1);
    private SpriteRenderer spriterendered;

    private void Start()
    {
        spriterendered = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package Picked up");
            hasPackage = true;
            Destroy(other.gameObject, 0.5f);
            spriterendered.color = hasPackageColor;

        }

        if (other.CompareTag("Boost") && hasPackage)
        {
            Debug.Log("Boost Activated");
            hasPackage = false;
            Destroy(other.gameObject, 0.5f);
            spriterendered.color = NoPackageColor;
        }
        
    }
}
