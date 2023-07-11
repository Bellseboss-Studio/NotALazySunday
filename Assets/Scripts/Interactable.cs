using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : MonoBehaviour
{
    private bool m_isOverlapped;
    private bool m_HasCliked;
    
    
    
    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_isOverlapped = true;
            Debug.Log(other.name + " is in");
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_isOverlapped = false;
        }
    }


    private void Update()
    {
        if (m_isOverlapped && Input.GetButtonDown("Fire1"))
        {
            PerformInteraction();
        }
    }

    protected virtual void PerformInteraction()
    {
       
    }
}