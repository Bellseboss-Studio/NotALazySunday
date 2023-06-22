using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Transform m_Transform;
    [SerializeField] private float m_Speed;

    void Update()
    {
        transform.Rotate( Vector3.forward, m_Speed * Time.deltaTime);
    }
}
