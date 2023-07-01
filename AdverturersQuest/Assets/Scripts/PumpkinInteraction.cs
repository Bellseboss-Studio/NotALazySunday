using System;
using System.Collections;
using UnityEngine;

public class PumpkinInteraction : Interactable
{
    private MeshRenderer m_MeshRenderer1;
    private MeshFilter m_MeshFilter;
    
    [SerializeField] private Mesh m_Mesh1;
    [SerializeField] private Mesh m_Mesh2;
    private void Start()
    {
        m_MeshFilter = GetComponent<MeshFilter>();
    }

    protected override void PerformInteraction()
    {
        StartCoroutine(BreakPumpkin());
    }

    IEnumerator BreakPumpkin()
    {
        m_MeshFilter.mesh = m_Mesh2;
        yield return new WaitForSeconds(2);
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        m_MeshFilter.mesh = m_Mesh1;
        while (transform.localScale.magnitude < 2.5f)
        {
            transform.localScale *= 0.1f;
        }
        
    }
}