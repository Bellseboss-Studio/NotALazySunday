using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Rotations
{
   RotateOnX,
   RotateOnY,
   RotateOnZ
}
public class BasicRotator : MonoBehaviour
{
    [SerializeField] private Rotations m_RotationAxis = new Rotations();
    private Vector3 m_VectorForRotation = new Vector3();
    [SerializeField] private Transform m_Transform;
    [SerializeField] private float m_Speed;
    [SerializeField] private bool m_Loop;
    [SerializeField] private float m_Length;

    private void Start()
    {
        CheckDependencies();
    }
    
    void Update()
    {
        RotateObject();
        if (!m_Loop)
        {
            StartCoroutine(MeasuredRotation());
        }
    }

    private void RotateObject()
    {
        transform.Rotate( m_VectorForRotation, m_Speed * Time.deltaTime);
    }

    IEnumerator MeasuredRotation()
    {
        yield return new WaitForSeconds(m_Length);
        m_Speed = 0;
    }
    private void CheckDependencies()
    {
        if (!m_Transform)
        {
            m_Transform = GetComponent<Transform>();
        }

        switch (m_RotationAxis)
        {
            case Rotations.RotateOnX:
                m_VectorForRotation = Vector3.right;
                break;
            case Rotations.RotateOnY:
                m_VectorForRotation = Vector3.up;
                break;
            case Rotations.RotateOnZ:
                m_VectorForRotation = Vector3.forward;
                break;

            
        }
    }
}
