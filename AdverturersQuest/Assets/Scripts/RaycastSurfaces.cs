using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSurfaces : MonoBehaviour
{
    [SerializeField] private float m_Range = 5;
    [SerializeField] private Vector3 m_Direction;
    public PhysicMaterial m_Hit;

    private void Update()
    {
        m_Direction  = Vector3.down;
        Ray theRay = new Ray(transform.position,transform.TransformDirection(m_Direction * m_Range));
        Debug.DrawRay(transform.position,transform.TransformDirection(m_Direction * m_Range));

        if (Physics.Raycast(theRay, out RaycastHit hit, m_Range))
        {
            m_Hit = hit.collider.material;
        }
    }
}
