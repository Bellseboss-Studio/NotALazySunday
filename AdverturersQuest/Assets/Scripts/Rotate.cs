using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Transform m_Transform;
    [SerializeField] private float m_Speed;

    private void Start()
    {
        CheckDependencies();
    }

    void Update()
    {
        transform.Rotate( Vector3.forward, m_Speed * Time.deltaTime);
    }

    private void CheckDependencies()
    {
        if (!m_Transform)
        {
            m_Transform = GetComponent<Transform>();
        }
    }
}
