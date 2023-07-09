using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool m_isOverlapped;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_isOverlapped = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_isOverlapped = false;
        }
    }


    private void Update()
    {
        if (m_isOverlapped && Input.GetAxis("Fire1") != 0)
        {
            PerformInteraction();
        }
    }

    protected virtual void PerformInteraction()
    {
       
    }
}