using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Interactable : MonoBehaviour
{
    private bool m_isOverlapped;
    private bool m_HasCliked;
    public bool m_ShowOptionToInteract;
    public Event m_ShowOptionToInteractEvent;

    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            m_isOverlapped = true;
            if (m_ShowOptionToInteract)
            {
                m_ShowOptionToInteractEvent.Occurred();
                m_ShowOptionToInteract = false;
            }
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