using System;
using System.Collections;
using UnityEngine;

public class RaycastToPhysicMaterial : MonoBehaviour
{
    [SerializeField] private float m_Range = 5;
    [SerializeField] private Vector3 m_Direction;
    public float m_Hit;
    
    public float DetectSurface()
    {
        m_Direction  = Vector3.down;
        Ray theRay = new Ray(transform.position,transform.TransformDirection(m_Direction * m_Range));
        Debug.DrawRay(transform.position,transform.TransformDirection(m_Direction * m_Range));

        if (Physics.Raycast(theRay, out RaycastHit hit, m_Range))
        {
            m_Hit = hit.textureCoord.x;
        }

        return (float)Math.Round(m_Hit,2);
    }
    
}