using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockThemAll : MonoBehaviour
{
    [SerializeField] private List<Event> m_UnlockEvents = new List<Event>();
    [SerializeField] private Event m_ShowNavMap; 
    [SerializeField] private Event m_HideNavMap;
    private bool m_IsNavMapVisible = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            foreach (Event message in m_UnlockEvents)
            {
                message.Occurred();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!m_IsNavMapVisible)
            {
                m_ShowNavMap.Occurred();
                m_IsNavMapVisible = !m_IsNavMapVisible;
            }
            else
            {
                m_HideNavMap.Occurred();
                m_IsNavMapVisible = !m_IsNavMapVisible;
            }
           
        }
    }
}
